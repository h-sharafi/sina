
import React, { useContext, useEffect } from 'react'
import { RootStoreContext } from '../../app/stores/rootStore';
import { observer } from 'mobx-react-lite';

const SiteSetting = () => {
    const rootStore = useContext(RootStoreContext);
    const { getSiteSetting, updateSiteSetting, siteSerring } = rootStore.siteSettingStore;

    useEffect(() => {
        getSiteSetting();
    }, [getSiteSetting]);

    return (
        <div>
            <p>تنظیمات سایت</p>
        </div>
    )
}

export default observer(SiteSetting)
