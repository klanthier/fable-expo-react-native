namespace Elmish.ReactNative.Expo

open Elmish.ReactNative
open Fable.React
open Fable.Core
open Elmish

[<RequireQualifiedAccess>]
module Program =
    open Elmish.React
    open Components

    [<Import("registerRootComponent", from="expo")>]
    let registerRootComponent : ReactElement -> unit = jsNative

    /// Setup rendering of root ReactNative component
    let withReactNativeExpo (program : Program<_, _, _, _>) =
        // Register expo root component
        registerRootComponent <| unbox JsInterop.jsConstructor<App>

        let setState m d =
             match appState with
             | Some state ->
                state.setState { state with render = fun () -> (Program.view program) m d }
             | _ ->
                appState <- Some { render = fun () -> (Program.view program) m d
                                   setState = ignore }

        program
        |> Program.withSetState setState
