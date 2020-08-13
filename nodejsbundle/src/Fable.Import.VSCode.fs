namespace Fable.Import
open System
open Fable.Core
open Fable.Core.JS
open Fable.Core.JsInterop

module vscode =
    type [<Import("Disposable","vscode")>] Disposable(callOnDispose: JsFunc) =
        static member from([<ParamArray>] disposableLikes: obj[]): Disposable = failwith "JS only"
        member __.dispose(): obj = failwith "JS only"
    let x = 10