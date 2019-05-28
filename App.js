import React from 'react';
import { View } from 'react-native';
import * as FableImports from './out/entry';

export default class App extends React.Component {
    render() {
        return (
            <View>
                <FableImports.Entry></FableImports.Entry>
            </View>
        );
    }
}
