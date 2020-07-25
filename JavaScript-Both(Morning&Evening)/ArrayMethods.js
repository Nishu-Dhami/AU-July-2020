<script>
var arr=[1,2,3,79,52,68,79,69,23,,,45];
console.log("Original arr is "+arr);
//Concat()
arr=arr.concat([56,65,78]);
console.log("After concat() array is "+arr);;
//every()
function func(arr){
  return arr>10;
}
console.log("every() on condition value>10 returns "+arr.every(func));//return false as every element is not >10
//filter()
arr=arr.filter(func);
console.log("After filtering array for values>10 "+arr);
//forEach()
arr.forEach(function func1(element,index,array){
  console.log("arr["+index+"]="+element)
});
//indexOf()
console.log("Index of 79 is "+arr.indexOf(79));
//lastIndexOf()
console.log("Last index of 79 is "+arr.lastIndexOf(79));
//join()
console.log("Join all elements with '$' "+arr.join("$"));
//map()
var newarr=arr.map(myfunc)
function myfunc(item){
return item*10;}
console.log(newarr);
//pop()
console.log("Top element is "+arr.pop());
console.log("Array after pop() function "+arr);
//push()
arr.push(95);
console.log("Array after pushing 95 "+arr);
//reduce()
console.log("Value obtained by subtracting value from left ot right "+arr.reduce(function myfunc(total,item){return total-item;}))
//reduceRight()
console.log("Value obtained by subtracting value from right to left "+arr.reduceRight(function myfunc(total,item){return total-item;}))
//reverse()
console.log("Reversing array "+arr.reverse());
//shift()
console.log("Leftmost element "+arr.shift())
console.log("After shifting array by right "+arr);
//slice()
arr=arr.slice(1,6)
console.log("New array after slicing first three elements "+arr)
//some()
function mfunc(item)
{
  return item>50;
}
console.log("Do array satisfies condition that some elements are >50 "+arr.some(mfunc));
//toSource()
//console.log(arr.toSource())
//sort()
console.log("Sorted Array "+arr.sort())
//splice()
console.log("Elements removed from array are"+arr.splice(3,4))
console.log("Array becomes "+arr)
//toSource()
console.log("Source is "+arr.toSource)
////toString()
arr[0]=toString(arr[0])
console.log("Converting first array element to string "+arr)
//unshift()
//arr=arr.unshift(15)
console.log("Length of array adding 15 at beggining "+arr.unshift(15))
console.log("Final array : "+arr)
window.alert("CHECK CONSOLE FOR RESULTS");
</script>