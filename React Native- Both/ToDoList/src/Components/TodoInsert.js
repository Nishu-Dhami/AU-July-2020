import React,{useState} from 'react';
import {Button, StyleSheet, TextInput, View, AsyncStorage} from 'react-native';

const TodoInsert=({onaddItem})=>{
    const [newTodo,setnewTodo]=useState('');

    const InputHandler=newTodoItem=>{
        setnewTodo(newTodoItem);
    };

    const addTodo = async()=>{
        await AsyncStorage.setItem("newTodo", newTodo);
        onaddItem(newTodo);
        setnewTodo('');
        alert("' "newTodo+" ' added to todo list");
    };
    return(
        <View style={styles.container}>
            <TextInput style={styles.input} placeholder="Add Item" onChangeText={InputHandler} value={newTodo}/>
            <Button title={"ADD"} onPress={addTodo}/>
        </View>
    );
}

const styles=StyleSheet.create({
    input: {
        flex:1,
        padding: 10,
        borderBottomColor: 'black',
        borderBottomWidth: 1,
        fontSize: 20,
        marginLeft: 10,
      },
      container:{
          flexDirection:'row',
          justifyContent:'space-between',
          alignItems:'center',
      },
})

export default TodoInsert;