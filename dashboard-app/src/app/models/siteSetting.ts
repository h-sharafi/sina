import { IFile } from "./file";

  
export interface ISiteSetting {
    siteLogo: IFile;
    footerLogo: IFile;
    favIcon: IFile;
    name: string;
    title: string;
    description: string;
  }
export interface ISiteSettingUpdate {
    name: string;
    title: string;
    description: string;
    keywords : string| null
}