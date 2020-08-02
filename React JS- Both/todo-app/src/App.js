import React, { useState } from "react";
import "./App.css";

function Todo({ todo, index, done, remove}) {
  return (
    <div style={{ textDecoration: todo.isCompleted ? "line-through" : ""}}>
      <p id="list">{todo.text}</p>
        <button id="cbtn" onClick={() => done(index)}>DONE</button>
        <button id="dbtn" onClick={() => remove(index)}>DELETE</button>
    </div>
  );
}

function TodoForm({ addTodo }) {
  const [title, setTitle] = useState("");

  const InputHandler = e => {
    e.preventDefault();
    if (!title) return;
    addTodo(title);
    setTitle("");
  };

  return (
    <form onSubmit={InputHandler}>
      <input type="text" class="form" value={title} placeholder="Enter todo item" onChange={e => setTitle(e.target.value)}/>
      <button type="submit" onSubmit={InputHandler} class="btn">ADD</button>
    </form>
  );
}

function App() {
  const [todos, setTodos] = useState([]);

  const addTodo = text => {
    const newTodo = [...todos, { text }];
    setTodos(newTodo);
    alert("' "+text+" ' is you new task!");
  };

  const done = index => {
    const newTodo = [...todos];
    newTodo[index].isCompleted = true;
    setTodos(newTodo);
    alert("You completed one task!");
  };

  const remove = index => {
    const newTodo = [...todos];
    newTodo.splice(index, 1);
    setTodos(newTodo);
    alert("Item deleted successfully!");
  };

  const removeAll=()=>{
    const newTodo=[...todos];
    for(var i=0;i<=todos.length;i++)
    {
      newTodo.splice(i,todos.length);
    }
    setTodos(newTodo);
    alert("Complete List will get deleted");
  }

  return (
    <div className="app">
    <div class="container">
      <TodoForm addTodo={addTodo} />
      <div class="card">{todos.map((todo, index) => ( 
        <Todo key={index} index={index} todo={todo} done={done} remove={remove} />
        ))}
      </div>
      <button id="all" onClick={removeAll}>DELETE ALL</button>
    </div>
    </div>
  );
}

export default App;