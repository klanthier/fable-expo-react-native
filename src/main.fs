module AwesomeApp.Main

open Fable.React
open Fable.ReactNative

type WelcomeProps = { name : string }

let welcomeView { name = name } =
    view [ Styles.container ] [
      text [] ("Welcome " + name)
    ]

let welcome name = ofFunction welcomeView { name = name } []

// // MODEL

// type Model = int


// type Msg =
//   | Increment
//   | Decrement


// let init() =
//   0


// // UPDATE

// let update (msg : Msg) count =
//   match msg with
//   | Increment ->
//       count + 1

//   | Decrement ->
//       count - 1


// let view count (dispatch : Dispatch<Msg>) =
//   let onClick msg =
//     fun () -> msg |> dispatch

//   view [ Styles.sceneBackground ]
//     [ Styles.button "-" (onClick Decrement)
//       text [] (string count)
//       Styles.button "+" (onClick Increment) ]

// // App
// Program.mkSimple init update view
// |> Program.withConsoleTrace
// |> Program.withReactNative "counter"
// |> Program.run


