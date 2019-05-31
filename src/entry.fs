module AwesomeApp.EntryPoint

open Elmish
open Elmish.ReactNative.Expo
open Fable.ReactNative
open Fable.ReactNative.Props

type Model = int

type Msg =
  | Increment
  | Decrement

let init() =
  0

let update (msg : Msg) count =
  match msg with
  | Increment ->
      count + 1

  | Decrement ->
      count - 1

let view count (dispatch : Dispatch<Msg>) =
  let onClick msg =
    fun () -> msg |> dispatch

  view [ Styles.entryContainer ] [
      view [ Styles.container ]
        [
            button [ ButtonProperties.OnPress <| onClick Increment; ButtonProperties.Title "Increase" ] []
            text [] (string count)
            button [ ButtonProperties.OnPress <| onClick Decrement; ButtonProperties.Title "Decrease" ] []
        ]
  ]


Program.mkSimple init update view
|> Program.withReactNativeExpo
|> Program.run
