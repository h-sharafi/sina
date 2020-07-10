import React, { Fragment } from 'react';
import { Route, Switch, RouteComponentProps, withRouter } from 'react-router-dom';
import logo from './logo.svg';
import './App.css';
import FileComponent from './feature/file/FileComponent';
import { observer } from 'mobx-react-lite';
import SiteSetting from './feature/siteSetting/SiteSetting';

const App: React.FC = () => {
  return (
    <>
      <Fragment>
        <Route exact path='/' component={FileComponent} />
        <Route
          path={'/(.+)'}
          render={() => (
            <Switch>
              <Route path='/Managment/FileWork' component={FileComponent} />
              <Route path='/Managment/SiteSetting' component={SiteSetting} />

            </Switch>
          )}
        />
      </Fragment>
    </>
  );
}

export default withRouter(observer(App));