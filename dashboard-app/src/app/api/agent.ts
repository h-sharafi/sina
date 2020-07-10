import axios, { AxiosResponse } from 'axios';
import { history } from '../..';
import { toast } from 'react-toastify';
import Swal from 'sweetalert2';
import { IFileUpload, IFile, IFileFilterModel, IReturnFileFilter } from '../models/file';
import { ISiteSettingUpdate, ISiteSetting } from '../models/siteSetting';



axios.defaults.baseURL = process.env.REACT_APP_API_URL;

console.log(axios.defaults.baseURL)
axios.interceptors.request.use(
  config => {
    const token = window.localStorage.getItem('jwt');
    if (token) config.headers.Authorization = `Bearer ${token}`;
    return config;
  },
  error => {
    return Promise.reject(error);
  }
);

axios.interceptors.response.use(undefined, error => {
  if (error.message === 'Network Error' && !error.response) {
    // toast.error('Network error - make sure API is running!');
    Swal.fire("Error!", "Network error - make sure API is running!", "error");
  }
  const { status, data, config, headers } = error.response;
  if (status === 404) {
    history.push('/notfound');
  }
  if (status === 401 && headers['www-authenticate'] === 'Bearer error="invalid_token", error_description="The token is expired"') {
    window.localStorage.removeItem('jwt');
    history.push('/')
    // toast.info('Your session has expired, please login again')
    Swal.fire("هشدار!", "لطفا وارد شوید", "success");
  }
  if (
    status === 400 &&
    config.method === 'get' &&
    data.errors.hasOwnProperty('id')
  ) {
    history.push('/notfound');
  }
  if (status === 500) {
    // toast.error('Server error - check the terminal for more info!');
    Swal.fire("هشدار!", "خطای سیستمی،  بعدا امتحان کنید", "success");

  }
  throw error.response;
});

const responseBody = (response: AxiosResponse) => response.data;

const requests = {
  get: (url: string) => axios.get(url).then(responseBody),
  post: (url: string, body: {}) => axios.post(url, body).then(responseBody),
  put: (url: string, body: {}) => axios.put(url, body).then(responseBody),
  del: (url: string) => axios.delete(url).then(responseBody),

  postForm: (url: string, file: IFileUpload) => {
    let formData = new FormData();
    formData.append("formFile", file.formFile);
    // file.formFile.forEach(sFile =>  formData.append("formFile",sFile));
    formData.append("title", file.title);
    if (file.fileCategoryId) { formData.append("fileCategoryId", file.fileCategoryId.toString()); }

    return axios
      .post(url, formData, {
        headers: { 'Content-type': 'multipart/form-data' }
      }).then(responseBody);
  }
};


// const ImageFile = {
//   upload: (file: IUploadImage): Promise<IFile> => requests.postForm(`/File`, file),
// }
const SiteSetting = {
  update: (model: ISiteSettingUpdate): Promise<ISiteSetting> => requests.post('/WebSiteSetting', model),
  get: (): Promise<ISiteSetting> => requests.get('/WebSiteSetting'),
}
const File = {
  upload: (file: IFileUpload): Promise<IFile> => requests.postForm(`/File`, file),
  getByFilter : (model : IFileFilterModel) : Promise<IReturnFileFilter> => requests.post('File/ByFilter' , model)
}
export default {
  SiteSetting, 
  File
};
