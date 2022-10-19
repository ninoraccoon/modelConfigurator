import * as React from 'react';

import { Col, Row } from 'antd';

export class About extends React.Component<any> {
  render() {
    return (
      <Row>
        <Col>
          <div>
            <div>
              <h2>About This Demo</h2>
            </div>
            <div>
              <p>
                This is a simple startup template For Model configration
                .
              </p>

            </div>
          </div>
        </Col>
      </Row>
    );
  }
}
export default About;
