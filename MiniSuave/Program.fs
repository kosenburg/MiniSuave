// Learn more about F# at http://fsharp.org

open System
open Suave.Http
open Suave
open Combinators
open Filters
open Suave

[<EntryPoint>]
let main argv =
    let request = { Route = ""; Type = Suave.Http.GET }
    let response = { Content = ""; StatusCode = 200 }
    let context = {Request = request; Response = response}
    
    Console.executeInLoop context (GET >=> Path "/hello" >=> Successful.OK "hello") 



    0 // return an integer exit code
