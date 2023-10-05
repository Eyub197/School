getBiggest :: Int -> Int -> Int -> Int
getBiggest x y z = if x >= y && x >= z
                     then x
                   else if y >= z
                     then y
                   else z

main :: IO ()
main = do
    putStrLn "Enter three numbers:"
    input1 <- getLine
    input2 <- getLine
    input3 <- getLine

    let num1 = read input1 :: Int
    let num2 = read input2 :: Int
    let num3 = read input3 :: Int

    let result = getBiggest num1 num2 num3

    putStrLn ("The biggest number is: " ++ show result)
