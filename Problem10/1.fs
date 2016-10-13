let nums = seq {2..2000000}
let sieve_stop = int (sqrt (float (Seq.last nums)))

let rec prime_iteration n p =
    let enumerator = Seq.item n p
    let primes = Seq.filter (fun index -> (index % enumerator <> 0 || index = enumerator)) p
    if enumerator < sieve_stop then
        prime_iteration (n+1) primes
    else
        primes

let primes_below_2million = (prime_iteration 0 nums)
let s = Seq.fold (fun acc elem -> acc + (float elem)) 0.0 primes_below_2million
printfn "%.12f" s

