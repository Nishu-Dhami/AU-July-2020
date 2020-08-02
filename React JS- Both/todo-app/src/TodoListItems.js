import React from 'react';
import './App.css';
class TodoListItems extends React.Component{

    render(){
        var todos=this.props.todos;

        return(
            <div>
            {todos.map((todo)=><div><p id="list">{todo.text}</p>
            <button id="dbtn" type="submit">DELETE</button></div>)}
            </div>
        );
    }
}

export default TodoListItems;   