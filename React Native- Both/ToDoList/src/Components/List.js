import React from 'react';
import {StyleSheet, ScrollView, Text} from 'react-native';

import ListItem from './ListItem';
const List=({todos,onRemove})=>{
    return(
        <ScrollView contentContainerStyle="alignItems:'center'">
            {todos.map(t=>(<ListItem key={t.id} {...t} onRemove={onRemove}/>))}
        </ScrollView>
    );
}

export default List;