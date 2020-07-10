

import { createContext } from 'react';
import { configure } from 'mobx';
import SiteSettingStore from './siteSettingStore';
import { threadId } from 'worker_threads';
import FileStore from './fileStore';


configure({ enforceActions: 'always' });

export class RootStore {
    url: string| undefined;
    siteSettingStore: SiteSettingStore;
    fileStore: FileStore;
    
    constructor() {
        this.url =  process.env.REACT_APP_File_URL;
        this.siteSettingStore = new SiteSettingStore(this);
        this.fileStore = new FileStore(this);
    }
}

export const RootStoreContext = createContext(new RootStore());