module internal Styles

open Fable.ReactNative.Props

let container =
    ViewProperties.Style [
        Flex 1.
        AlignItems ItemAlignment.Center
        JustifyContent JustifyContent.Center
    ]

let entryContainer =
    ViewProperties.Style [
        Width <| unbox "100%"
        Height <| unbox "100%"
    ]
