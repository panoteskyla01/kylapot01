function  add1(p1,p2){
    return Number (p1) + Number(p2);
}
function addition(){
    let num1=document.getElementById("add1").value; 
    let num2=document.getElementById("add2").value;
    let result=add1(num1, num2);
    document.getElementById("sagot").value=result;
}
function subtraction(){
    let num3=document.getElementById("subb3").value;
    let num4=document.getElementById("subb4").value;
    let result=subb2(num1,  num2);
    document.getElementById("sagot").value=result;
}
