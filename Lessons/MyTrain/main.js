let arr1 = [1, 2, 3, 4, 5, 7];
let arr2 = [1, 3, 3, 4, 5, 7];

let maxCount = 0;
let count = 0;

for (let i = 0; i < arr1.length; i++) {
  if (arr1[i] === arr2[i]) {
    count += 1;
    if (count > maxCount) {
      maxCount = count;
    }
  } else {
    count = 0;
  }
}

console.log(maxCount);

//Напишите однострочное решение, которое вычисляет сумму квадратных корней для всех чётных чисел целочисленного массива.



let ar = [1,2,3,4,16,6] 
let sum = 0
function Vichisli (){
    for (let i = 0; i < ar.length; i++) {
        if(ar[i]%2===0){
            console.log(`${ar[i]} прошел 1 условие`)
            if(ar[i]===Math.sqrt(ar[i])*Math.sqrt(ar[i])){
                sum+= Math.sqrt(ar[i])
                console.log(`${ar[i]} прошел 2 условие и наша сумма = ${sum}`)
            }
        } else{
            console.log(`${ar[i]} не прошел вообще`)
        }
    }
     console.log(`${sum}`)
}
Vichisli ()