# Integrating Swiss Confederation Design System with MudBlazor Template
This document outlines the steps taken to integrate the [Design System for the Swiss Confederation](https://github.com/swiss/designsystem) with a MudBlazor-based Blazor Server template.

## 1. CSS Integration
### Source
The CSS was downloaded from the [Design System for the Swiss Confederation releases page](https://github.com/swiss/designsystem/releases).

### Storage Location
The downloaded CSS file (v1.0.26.css) was stored in the following directory:

```bash
./wwwroot/swiss-confederation/v1.0.26.css
```


## 2. Fonts Integration
### Source
The fonts were obtained from the [Design System fonts repository](https://github.com/swiss/designsystem/tree/main/css/foundations/fonts).

### Stored Fonts
The following font files were included:

- NotoSans-Regular.ttf
- NotoSans-BoldItalic.ttf
- NotoSans-Italic.ttf
- NotoSans-Bold.ttf

### Storage Location
The fonts were stored in the following directory:

```bash
./wwwroot/swiss-confederation/fonts
```

The full file structure for the fonts:

```bash
./wwwroot/swiss-confederation/fonts/NotoSans-Regular.ttf
./wwwroot/swiss-confederation/fonts/NotoSans-BoldItalic.ttf
./wwwroot/swiss-confederation/fonts/NotoSans-Italic.ttf
./wwwroot/swiss-confederation/fonts/NotoSans-Bold.ttf
```

## 4. Blazor Integration
### Stylesheet Inclusion
The Swiss Confederation CSS file was included in the ```App.razor``` file as follows:

```html
<link rel="stylesheet" href="swiss-confederation/v1.0.26.css" />
```
This setup ensures a cohesive and consistent design that aligns with the official Swiss Confederation standards while leveraging MudBlazor's component-based framework.