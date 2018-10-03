﻿using System.Collections.Generic;

namespace LmpCommon.ModFile.Structure
{
    public class MandatoryPart
    {
        public string Text { get; set; }
        public string Link { get; set; }
        public string PartName { get; set; }
    }

    public class ForbiddenPart
    {
        public string Text { get; set; }
        public string PartName { get; set; }
    }

    public class MandatoryDllFile
    {
        public string Text { get; set; }
        public string Link { get; set; }
        public string FilePath { get; set; }
        public string Sha { get; set; }
    }

    public class ForbiddenDllFile
    {
        public string Text { get; set; }
        public string FilePath { get; set; }
    }

    public class ModControlStructure
    {
        public bool AllowNonListedPlugins { get; set; } = true;
        public List<string> RequiredExpansions { get; set; } = new List<string>();
        public List<MandatoryDllFile> MandatoryPlugins { get; set; } = new List<MandatoryDllFile>();
        public List<ForbiddenDllFile> ForbiddenPlugins { get; set; } = new List<ForbiddenDllFile>();
        public List<MandatoryPart> MandatoryParts { get; set; } = new List<MandatoryPart>();
        public List<ForbiddenPart> ForbiddenParts { get; set; } = new List<ForbiddenPart>();
        public List<string> AllowedParts { get; set; } = new List<string>()
        {
            "StandardCtrlSrf",
            "CanardController",
            "noseCone",
            "AdvancedCanard",
            "airplaneTail",
            "deltaWing",
            "noseConeAdapter",
            "rocketNoseCone",
            "smallCtrlSrf",
            "standardNoseCone",
            "sweptWing",
            "tailfin",
            "wingConnector",
            "winglet",
            "R8winglet",
            "winglet3",
            "Mark1Cockpit",
            "Mark2Cockpit",
            "Mark1-2Pod",
            "advSasModule",
            "asasmodule1-2",
            "avionicsNoseCone",
            "crewCabin",
            "cupola",
            "landerCabinSmall",
            "mark3Cockpit",
            "mk1pod",
            "mk2LanderCabin",
            "probeCoreCube",
            "probeCoreHex",
            "probeCoreOcto",
            "probeCoreOcto2",
            "probeCoreSphere",
            "probeStackLarge",
            "probeStackSmall",
            "sasModule",
            "seatExternalCmd",
            "rtg",
            "batteryBank",
            "batteryBankLarge",
            "batteryBankMini",
            "batteryPack",
            "ksp.r.largeBatteryPack",
            "largeSolarPanel",
            "solarPanels1",
            "solarPanels2",
            "solarPanels3",
            "solarPanels4",
            "solarPanels5",
            "JetEngine",
            "engineLargeSkipper",
            "ionEngine",
            "liquidEngine",
            "liquidEngine1-2",
            "liquidEngine2",
            "liquidEngine2-2",
            "liquidEngine3",
            "liquidEngineMini",
            "microEngine",
            "nuclearEngine",
            "radialEngineMini",
            "radialLiquidEngine1-2",
            "sepMotor1",
            "smallRadialEngine",
            "solidBooster",
            "solidBooster1-1",
            "toroidalAerospike",
            "turboFanEngine",
            "MK1Fuselage",
            "Mk1FuselageStructural",
            "RCSFuelTank",
            "RCSTank1-2",
            "rcsTankMini",
            "rcsTankRadialLong",
            "fuelTank",
            "fuelTank1-2",
            "fuelTank2-2",
            "fuelTank3-2",
            "fuelTank4-2",
            "fuelTankSmall",
            "fuelTankSmallFlat",
            "miniFuelTank",
            "mk2Fuselage",
            "mk2SpacePlaneAdapter",
            "mk3Fuselage",
            "mk3spacePlaneAdapter",
            "radialRCSTank",
            "toroidalFuelTank",
            "xenonTank",
            "xenonTankRadial",
            "adapterLargeSmallBi",
            "adapterLargeSmallQuad",
            "adapterLargeSmallTri",
            "adapterSmallMiniShort",
            "adapterSmallMiniTall",
            "nacelleBody",
            "radialEngineBody",
            "smallHardpoint",
            "stationHub",
            "structuralIBeam1",
            "structuralIBeam2",
            "structuralIBeam3",
            "structuralMiniNode",
            "structuralPanel1",
            "structuralPanel2",
            "structuralPylon",
            "structuralWing",
            "strutConnector",
            "strutCube",
            "strutOcto",
            "trussAdapter",
            "trussPiece1x",
            "trussPiece3x",
            "CircularIntake",
            "landingLeg1",
            "landingLeg1-2",
            "RCSBlock",
            "stackDecoupler",
            "airScoop",
            "commDish",
            "decoupler1-2",
            "dockingPort1",
            "dockingPort2",
            "dockingPort3",
            "dockingPortLarge",
            "dockingPortLateral",
            "fuelLine",
            "ladder1",
            "largeAdapter",
            "largeAdapter2",
            "launchClamp1",
            "linearRcs",
            "longAntenna",
            "miniLandingLeg",
            "parachuteDrogue",
            "parachuteLarge",
            "parachuteRadial",
            "parachuteSingle",
            "radialDecoupler",
            "radialDecoupler1-2",
            "radialDecoupler2",
            "ramAirIntake",
            "roverBody",
            "sensorAccelerometer",
            "sensorBarometer",
            "sensorGravimeter",
            "sensorThermometer",
            "spotLight1",
            "spotLight2",
            "stackBiCoupler",
            "stackDecouplerMini",
            "stackPoint1",
            "stackQuadCoupler",
            "stackSeparator",
            "stackSeparatorBig",
            "stackSeparatorMini",
            "stackTriCoupler",
            "telescopicLadder",
            "telescopicLadderBay",
            "SmallGearBay",
            "roverWheel1",
            "roverWheel2",
            "roverWheel3",
            "wheelMed",
            "flag",
            "kerbalEVA",
            "mediumDishAntenna",
            "GooExperiment",
            "science.module",
            "RAPIER",
            "Large.Crewed.Lab",
            "GrapplingDevice",
            "LaunchEscapeSystem",
            "MassiveBooster",
            "PotatoRoid",
            "Size2LFB",
            "Size3AdvancedEngine",
            "size3Decoupler",
            "Size3EngineCluster",
            "Size3LargeTank",
            "Size3MediumTank",
            "Size3SmallTank",
            "Size3to2Adapter",
            "omsEngine",
            "vernierEngine",
            "delta.small",
            "elevon2",
            "elevon3",
            "elevon5",
            "IntakeRadialLong",
            "MK1IntakeFuselage",
            "mk2.1m.AdapterLong",
            "mk2.1m.Bicoupler",
            "mk2CargoBayL",
            "mk2CargoBayS",
            "mk2Cockpit.Inline",
            "mk2Cockpit.Standard",
            "mk2CrewCabin",
            "mk2DockingPort",
            "mk2DroneCore",
            "mk2FuselageLongLFO",
            "mk2FuselageShortLFO",
            "mk2FuselageShortLiquid",
            "mk2FuselageShortMono",
            "shockConeIntake",
            "structuralWing2",
            "structuralWing3",
            "structuralWing4",
            "sweptWing1",
            "sweptWing2",
            "wingConnector2",
            "wingConnector3",
            "wingConnector4",
            "wingConnector5",
            "wingStrake",
            "adapterMk3-Mk2",
            "adapterMk3-Size2",
            "adapterMk3-Size2Slant",
            "adapterSize2-Mk2",
            "adapterSize2-Size1",
            "adapterSize2-Size1Slant",
            "adapterSize3-Mk3",
            "mk3CargoBayL",
            "mk3CargoBayM",
            "mk3CargoBayS",
            "mk3Cockpit.Shuttle",
            "mk3CrewCabin",
            "mk3FuselageLF.100",
            "mk3FuselageLF.25",
            "mk3FuselageLF.50",
            "mk3FuselageLFO.100",
            "mk3FuselageLFO.25",
            "mk3FuselageLFO.50",
            "mk3FuselageMONO",
            "kerbalEVAfemale",
            "airbrake1",
            "airlinerCtrlSrf",
            "airlinerMainWing",
            "airlinerTailFin",
            "pointyNoseConeA",
            "pointyNoseConeB",
            "airplaneTailB",
            "fairingSize1",
            "fairingSize2",
            "fairingSize3",
            "HeatShield1",
            "HeatShield2",
            "HeatShield3",
            "wingShuttleDelta",
            "elevonMk3",
            "wingShuttleElevon1",
            "wingShuttleElevon2",
            "wingShuttleRudder",
            "wingShuttleStrake",
            "delta.small",
            "mk2Cockpit.Inline",
            "mk2Cockpit.Standard",
            "mk3Cockpit.Shuttle",
            "ksp.r.largeBatteryPack",
            "solidBooster.sm",
            "fuelTank.long",
            "mk2.1m.Bicoupler",
            "mk2.1m.AdapterLong",
            "mk3FuselageLFO.100",
            "mk3FuselageLFO.25",
            "mk3FuselageLFO.50",
            "mk3FuselageLF.100",
            "mk3FuselageLF.25",
            "mk3FuselageLF.50",
            "xenonTankLarge",
            "mk3Cockpit.Shuttle",
            "FuelCell",
            "FuelCellArray",
            "ISRU",
            "LargeTank",
            "OrbitalScanner",
            "RadialDrill",
            "SmallTank",
            "SurfaceScanner",
            "SurveyScanner",
            "sensorAtmosphere",
            "Large.Crewed.Lab",
            "science.module",
            "radialDrogue",
            "ServiceBay.125",
            "ServiceBay.250",
            "GearFixed",
            "GearFree",
            "GearLarge",
            "GearMedium",
            "basicFin",
            "foldingRadLarge",
            "foldingRadMed",
            "foldingRadSmall",
            "radPanelLg",
            "radPanelSm",
            "turboJet",
            "turboFanSize2",
            "miniJetEngine",
            "SSME",
            "adapterEngines",
            "miniFuselage",
            "miniIntake",
            "MK1CrewCabin",
            "MiniISRU",
            "MiniDrill",
            "RadialOreTank",
            "radPanelEdge",
            "mk3CargoRamp",
            "InflatableHeatShield",
            "HECS2.ProbeCore",
            "HighGainAntenna",
            "LgRadialSolarPanel",
            "GearSmall",
            "ScienceBox",
            "SurfAntenna",
            "HighGainAntenna5",
            "RelayAntenna100",
            "RelayAntenna5",
            "RelayAntenna50",
            "HeatShield0",
            "InfraredTelescope",
            "kerbalEVAVintage",
            "kerbalEVAfemaleVintage",
            "mk1-3pod",
            "Decoupler_0",
            "Decoupler_1",
            "Decoupler_2",
            "Decoupler_3",
            "Separator_0",
            "Separator_1",
            "Separator_2",
            "Separator_3",
            "externalTankCapsule",
            "externalTankRound",
            "externalTankToroid",
            "Rockomax16_BW",
            "Rockomax32_BW",
            "Rockomax64_BW",
            "Rockomax8BW",
            "Decoupler.0",
            "Decoupler.1",
            "Decoupler.2",
            "Decoupler.3",
            "Separator.0",
            "Separator.1",
            "Separator.2",
            "Separator.3",
            "Rockomax16.BW",
            "Rockomax32.BW",
            "Rockomax64.BW",
            "Decoupler.1p5",
            "Decoupler.4",
            "EnginePlate1p5",
            "EnginePlate2",
            "EnginePlate3",
            "EnginePlate4",
            "InflatableAirlock",
            "Separator.1p5",
            "Separator.4",
            "Size1p5.Strut.Decoupler",
            "LiquidEngineKE-1",
            "LiquidEngineLV-T91",
            "LiquidEngineLV-TX87",
            "LiquidEngineRE-I2",
            "LiquidEngineRE-J10",
            "LiquidEngineRK-7",
            "LiquidEngineRV-1",
            "monopropMiniSphere",
            "Size1p5.Monoprop",
            "Size1p5.Size0.Adapter.01",
            "Size1p5.Size1.Adapter.01",
            "Size1p5.Size1.Adapter.02",
            "Size1p5.Size2.Adapter.01",
            "Size1p5.Tank.01",
            "Size1p5.Tank.02",
            "Size1p5.Tank.03",
            "Size1p5.Tank.04",
            "Size1p5.Tank.05",
            "Size3.Size4.Adapter.01",
            "Size4.EngineAdapter.01",
            "Size4.Tank.01",
            "Size4.Tank.02",
            "Size4.Tank.03",
            "Size4.Tank.04",
            "roverWheelM1-F",
            "fairingSize1p5",
            "fairingSize4",
            "Size1to0ServiceModule",
            "ServiceModule18",
            "ServiceModule25",
            "kv1Pod",
            "kv2Pod",
            "kv3Pod",
            "Mk2Pod",
            "MEMLander",
            "EquiTriangle0",
            "EquiTriangle1",
            "EquiTriangle1p5",
            "EquiTriangle2",
            "Panel0",
            "Panel1",
            "Panel1p5",
            "Panel2",
            "Triangle0",
            "Triangle1",
            "Triangle1p5",
            "Triangle2",
            "Tube1",
            "Tube1p5",
            "Tube2",
            "Tube3",
            "Tube4",
            "HeatShield1p5",
        };
    }
}
