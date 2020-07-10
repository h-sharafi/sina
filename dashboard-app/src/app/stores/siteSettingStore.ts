import { observable, action, runInAction, toJS } from 'mobx';
import { toast } from 'react-toastify';
import agent from '../api/agent';
import { RootStore } from './rootStore';
import { ISiteSetting, ISiteSettingUpdate } from '../models/siteSetting';

export default class SiteSettingStore {
    rootStore: RootStore;
    constructor(rootStore: RootStore) {
        this.rootStore = rootStore;
    }
    @observable siteSerring: ISiteSetting | null = null;

    @action updateSiteSetting = async (model: ISiteSettingUpdate) => {
        await agent.SiteSetting.update(model).then((result) => {
            runInAction(() => {
                this.siteSerring = result;
            });
        });
    }
    @action getSiteSetting = async () => {
        await agent.SiteSetting.get().then((result) => {
            runInAction(() => {
                this.siteSerring = result;
            });
        });
    }

};