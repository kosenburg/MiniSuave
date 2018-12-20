// Learn more about F# at http://fsharp.org

open Suave.Http
open Suave
open Combinators
open Filters



[<EntryPoint>]
let main argv =
    let request = { Route = ""; Type = Suave.Http.GET }
    let response = { Content = ""; StatusCode = 200 }
    let context = { Request = request; Response = response }

    let app = Choose [
        GET >=> Path "/hello" >=> Successful.OK "Hello GET"
        POST >=> Path "/hello" >=> Successful.OK "Hello Post"
        Path "/foo" >=> Choose [
            GET >=> Successful.OK "Foo GET"
            POST >=> Successful.OK "Foo POST"
        ]
    ]

    Console.executeInLoop context app



    0 // return an integer exit code
