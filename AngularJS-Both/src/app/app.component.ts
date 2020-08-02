import { Component,OnInit } from '@angular/core';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {

  title = 'AngularJS-session';
  sorted=false;
  newUser = {firstname:'',lastname:'',age:"",empId:'',loc:''};
  user1 = {firstname:'Nishu',lastname:'Dhami',age:"21",empId:'INT445',loc:'Gurugram'};
  user2 = {firstname:'Kanak',lastname:'Yadav',age:"22",empId:'INT552',loc:'Delhi'};
  name = [this.user1,this.user2];

  ngOnInit(){ 

  }
    
  clear=()=>{
      this.newUser.age="";
      this.newUser.empId="";
      this.newUser.firstname="";
      this.newUser.loc="";
      this.newUser.lastname="";
      return;
  }
  addUser = () =>{
      let temp = {firstname:'',lastname:'',age:"",empId:'',loc:''};
      temp.firstname = this.newUser.firstname;
      temp.lastname = this.newUser.lastname;
      temp.age = this.newUser.age;
      temp.empId = this.newUser.empId;
      temp.loc = this.newUser.loc;
      this.name.push(temp);
      alert("Record AddedSuccessfully! \n Click 'CLEAR' to reset form");
      return ;
  } 
  
  sortUser=()=>{
    alert("Click on column record to sort data column-wise(both asc & desc)");
  }
  sortbyfname = () =>{
    if(!this.sorted)
     { this.name.sort((a,b) => a.firstname.localeCompare(b.firstname));
      this.sorted=true;}
      else{
        this.name.sort((a,b) => b.firstname.localeCompare(a.firstname));
        this.sorted=false;
      }
     return ;
  }
  sortbylname = () =>{
    if(!this.sorted){
    this.name.sort((a,b) => a.lastname.localeCompare(b.lastname));
    this.sorted=true;
    }
    else
    {
      this.name.sort((a,b) => b.lastname.localeCompare(a.lastname));
      this.sorted=false;
    }
    return ;
 }
 sortbyage = () =>{
   if(!this.sorted){
  this.name.sort((a,b) => a.age.localeCompare(b.age));
  this.sorted=true;}
  else{
    this.name.sort((a,b) => b.age.localeCompare(a.age));
    this.sorted=false;
  }
  return ;
}
sortbyempid = () =>{
  if(!this.sorted){
  this.name.sort((a,b) => a.empId.localeCompare(b.empId));
  this.sorted=true;
  }
  else{
    this.name.sort((a,b) => b.empId.localeCompare(a.empId));
    this.sorted=false;
  }
  return ;
}
sortbyloc = () =>{
  if(!this.sorted){
  this.name.sort((a,b) => a.loc.localeCompare(b.loc));
  this.sorted=true;
  }
  else
  {
    this.name.sort((a,b) => b.loc.localeCompare(a.loc));
    this.sorted=false;
  }
  return ;
}

updateUser= () =>{
  alert("You can edit user details based on Employee ID only");
  let temp = {firstname:'',lastname:'',age:"",empId:'',loc:''};
      temp.firstname = this.newUser.firstname;
      temp.lastname = this.newUser.lastname;
      temp.age = this.newUser.age;
      temp.empId = this.newUser.empId;
      temp.loc = this.newUser.loc;
      var num : Number = null;
      for(var i=0;i<this.name.length;i++){
        var obj = this.name[i];
        if(obj.empId == this.newUser.empId){
          this.name[i] = temp;
          break;
        }
      }
      
      alert("Record Updated Successfully! \n Click 'CLEAR' to reset form");
}

deleteUser=()=>{
  alert("Enter Employee ID you wanna delete!");
  for(var i=0;i<this.name.length;i++){
    var obj = this.name[i];
    if(obj.empId == this.newUser.empId){
      this.name.splice(i,1);
      break;
    }
  }
  alert("Record Deleted Successfully! \n Click 'CLEAR' to reset form");
}
   username : 'nishu';
}