import * as React from 'react';
import { RouteComponentProps } from 'react-router-dom';

export default class File extends React.Component<RouteComponentProps<{ poop?: string }>, {}> {
    public render() {
        return <div>
            <h1>Hello freaking world</h1>
            <div>
            <p>Ok, I am adding a bit of text</p>
            </div>
            <div>
                {this.props.match.params.poop}
            </div>
        </div>
            
    }
}