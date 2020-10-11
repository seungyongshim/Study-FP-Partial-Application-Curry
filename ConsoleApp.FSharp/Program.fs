let f x y z = x * y + z
let pa x = f x 3 5

let c1 = f 2 
let c2 = c1 3
let c3 = c2 5

printfn "Curry: %A" c3
printfn "PA: %A" (pa 2)