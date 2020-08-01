const express =require('express');
const app=express()
const port=4000;
var Parser=require("body-parser");
app.use(Parser.json());
app.use(Parser.urlencoded({extended:true}));

var todos=[{id:1,title:"Complete assignments"},{id:2,title:"Buy essentials"}];

app.get('/todolist',(request,response)=>{
    response.status(200).send(todos)
});

app.post('/addtodo',(request,response)=>{
    var newTodo=request.body.newtask;
    newTodo.id=todos.length+1;
    todos.push(newTodo);
    response.status(201).send();
});

app.put('/update',(request,response)=>{
    var id=request.params.id;
    if(id<1||id>todos.length)
    response.status(404).send();
    else{
        var newTodo=request.body.newtask;
        todos[id]=newTodo;
        response.status(204,"Item Updates successfully!").send();
    }
});

app.delete('/deleltetodo',(request,response)=>{
    var id=parseInt(request.params.id);
    if(todos[id])
    {
        todos=todos.filter(t=>t.id!==id);
        response.send("Item deleted successfully");
    }
    else{
        response.status(404).send();
    }
});

app.listen(port,()=>{
    console.log("Running on localhost: "+port);
});