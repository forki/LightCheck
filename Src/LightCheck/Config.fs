﻿module LightCheck.Config

type Config =
    { MaxTest : int
      MaxFail : int
      Size    : int -> int
      Every   : int -> List<string> -> string }

let quick =
    { MaxTest = 100
      MaxFail = 1000
      Size    = fun n -> 3 + n / 2
      Every   =
          fun n args ->
              let s = n.ToString()

              let a =
                  [ for c in s -> char System.Environment.NewLine ]
                  |> Array.ofList
                  |> System.String
              s + a }