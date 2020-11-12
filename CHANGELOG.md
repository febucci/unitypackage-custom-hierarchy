
# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/).

## [Unreleased]

## [1.1.0] - Package Manager support - 2020.11.12
### Added
- Package Manager support, by [@pdcprod](https://github.com/pdcprod).
- Package information for the Unity's Package Manager.
- Option to stop updating the hierarchy inside Unity's PlayMode (to improve performance).

### Fixed
- Drawing the hierarchy when the first scene is unloaded, by [@rtauziac](https://github.com/rtauziac)

### Changed
- Moved scripts inside "Editor" folder to respect the [Package Layout rules](https://docs.unity3d.com/2020.1/Documentation/Manual/cus-layout.html).

### Removed
- Examples folder and EditorDefault resources.

## [1.0.0] - First Release - 2020.10.20
First Release.
