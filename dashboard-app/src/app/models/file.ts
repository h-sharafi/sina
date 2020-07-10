import { ISiteSetting } from "./siteSetting";
import { IBaseModel } from "./baseModel";

export interface IFileUpload {
    title: string,
    name: string,
    description: string,
    fileCategoryId: number | null,
    formFile: Blob
}

export interface IFile  extends IBaseModel{
    // FileModifiedUser: Array<ModifiedUser<File>>;
    id: number,
    name: string;
    description: string;
    cartTitle: string;
    title: string;
    fileCategory: IFileCategory;
    fileCategoryId: number  | null;
    imageFile: File;
    imageFileId: number | undefined | null;
    isPodcast: boolean;
    logoSiteSetting: ISiteSetting;
    logoSiteSettingId: number | undefined | null;
    favIconSetting: ISiteSetting;
    favIconSettingId: number | undefined | null;
    footerLogoSiteSetting: ISiteSetting;
    footerLogoSiteSettingId: number | undefined | null;
    

  }
  
  export interface IFileCategory {
    name: string;
    parent: IFileCategory;
    parentId: number;
    children: Array<IFileCategory>;
    files: Array<File>;
  }
  

  export interface IAccessAbleFile {
    name: string;
    type: string;
    files: IFile[]|[];
  }


  
export interface IFileFilter {
  type: string, 
  isUp : boolean, 
}

export interface IFileFilterModel {
   fileFilter : IFileFilter| null, 
   pageIndex: number,
   pageSize : number
}
export interface IReturnFileFilter {
  files: IFile[],
  totlaPage : number,
  totalCount: number
}
  