import * as React from 'react';
import { connect } from 'react-redux';

export class MyInfo extends React.Component {
    render() {
        return (
            <div>
                <h1> Maks</h1>
                <p>
                    My name Maks,I study in STEP academy. Now we write code on React technologe. I dont like js because i work on c# language.
                </p>
                <ol className="list-group">
                    <li className="list-group-item">New York</li>
                    <li className="list-group-item">London</li>
                    <li className="list-group-item">Paris</li>
                </ol>
            </div>
        );
    }
}



export default connect()(MyInfo);
