import * as React from 'react';
import { Layout } from 'antd';
import './index.less';
const Footer = () => {
  
  return (
    <Layout.Footer className={'footer'} style={{ textAlign: 'center' }}>
      Model Configurator © 2022 <a href="">Demo 1.00</a>
    </Layout.Footer>
  );
};
export default Footer;
