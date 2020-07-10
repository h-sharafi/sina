import { observable, action, runInAction, toJS } from 'mobx';
import { toast } from 'react-toastify';
import agent from '../api/agent';
import { RootStore } from './rootStore';
import { ISiteSetting, ISiteSettingUpdate } from '../models/siteSetting';
import { IFile, IFileFilterModel } from '../models/file';

export default class FileStore {
    rootStore: RootStore;
    constructor(rootStore: RootStore) {
        this.rootStore = rootStore;
    }

    @observable Files = new Map<number, IFile>();
    @observable FileList: IFile[] = [];
    @observable totlaPage: number = 0;
    @observable totalCount: number = 0;

    @action ClearFiles = () =>{
        runInAction(()=>{
            this.FileList=[];
        })
    }
    @action GetFiles = async (model: IFileFilterModel) => {
        try {
            await agent.File.getByFilter(model).then((result) => {
                runInAction(() => {
                    this.FileList = result.files;
                    this.totalCount = result.totalCount;
                    this.totlaPage = result.totlaPage;
                });
            });
        } catch (error) {

        }
    }
};