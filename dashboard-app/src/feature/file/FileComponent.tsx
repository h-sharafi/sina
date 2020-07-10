import React, { useContext, useEffect } from 'react'
import { RootStoreContext } from '../../app/stores/rootStore';
import { runInAction } from 'mobx';
import { observer } from 'mobx-react-lite';
import FileListComponent from './FileListComponent';

const FileComponent = () => {
    const rootStore = useContext(RootStoreContext);
    const { FileList, GetFiles, ClearFiles } = rootStore.fileStore;

    useEffect(() => {
        GetFiles({
            fileFilter: {
                type: 'title',
                isUp: true,
            },
            pageIndex: 1,
            pageSize: 12
        })
        return () => {
            runInAction(() => { ClearFiles(); })
        }
    }, [GetFiles])
    return (
        <div>
            {FileList.length === 0 && <p>فایلی موجود نتیست </p>}
            {FileList.length > 0 && <FileListComponent files= {FileList} />}
        </div>
    )
}

export default observer(FileComponent);
