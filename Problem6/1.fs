let numbers = seq {1.0..100.0}
let square = Seq.sumBy (fun x -> x**2.0) numbers
let sum_square = (Seq.sum numbers)**2.0

printfn "%A" (sum_square - square)
