import * as React from 'react';
import { Link, RouteComponentProps } from 'react-router-dom';
import { connect } from 'react-redux';
import { ApplicationState }  from '../store';

type CounterProps =
    CounterStore.CounterState
    & typeof CounterStore.actionCreators
    & RouteComponentProps<{}>;

class Animals extends React.Component<CounterProps, {}> {
    public render() {
        return <div>
            <h1>Animals</h1>
        </div>;
    }
}