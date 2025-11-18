# HardwareShop

Windows Forms inventory & billing manager for a small hardware store. This repo contains the Visual Studio solution and project sources used to build the app.

## Overview
- Desktop app built on .NET Framework 4.7.2
- Main responsibilities:
  - Inventory / product management (`HardwareShop.frm_productsinfo` — [`HardwareShop.frm_productsinfo`](HardwareShop/frm_productsinfo.cs))
  - Stock control (`HardwareShop.frmStock_info` — [`HardwareShop.frmStock_info`](HardwareShop/frmStock_info.cs))
  - Billing for customers and dealers (`HardwareShop.frmC_billtable`, `HardwareShop.frmD_billtable` — [`HardwareShop.frmC_billtable`](HardwareShop/frmC_billtable.cs), [`HardwareShop.frmD_billtable`](HardwareShop/frmD_billtable.cs))
  - Dealer management & reports (`HardwareShop.DealerReg`, `HardwareShop.rptDealerReg` — [`HardwareShop.DealerReg`](HardwareShop/DealerReg.cs), [`HardwareShop.rptDealerReg`](HardwareShop/rptDealerReg.cs))

## Quick start
1. Open the solution: [HardwareShop.sln](HardwareShop.sln).  
2. Build in Visual Studio (2017/2019/2022 recommended) — solution uses [`HardwareShop/HardwareShop.csproj`](HardwareShop/HardwareShop.csproj).
3. Run the project. App entry is in [`HardwareShop.Program`](HardwareShop/Program.cs).

## Default login
The app's login is implemented in [`HardwareShop.loginPage`](HardwareShop/loginPage.cs).  
Default credentials in the sample code:
- Username: `dmb`
- Password: `password`

Change or replace this stub with a secure auth in production.


## Important files
- Startup: [`HardwareShop.Program`](HardwareShop/Program.cs)
- UI forms:
  - Dashboard: [`HardwareShop.frmDashboard`](HardwareShop/frmDashboard.cs)
  - Main window: [`HardwareShop.Form1`](HardwareShop/Form1.cs)
  - Price editor: [`HardwareShop.frm_Priceinfo`](HardwareShop/frm_Priceinfo.cs)
  - Customer bill view: [`HardwareShop.Customerbillinfo`](HardwareShop/Customerbillinfo.cs)
  - Dealer bill view: [`HardwareShop.DealerBillInfo`](HardwareShop/DealerBillInfo.cs)
- Project file: [HardwareShop/HardwareShop.csproj](HardwareShop/HardwareShop.csproj)
- Resources & localization: [HardwareShop/Properties/Resources.resx](HardwareShop/Properties/Resources.resx)

## Build from command line
- Using MSBuild:
  ```
  msbuild HardwareShop.sln /p:Configuration=Debug
  ```
- You can launch the binary:
  ```
  start HardwareShop\bin\Debug\HardwareShop.exe
  ```

## Notes and recommendations
- The included login is a placeholder. Replace it with secure authentication before shipping. See [`HardwareShop.loginPage`](HardwareShop/loginPage.cs).
- Review `App.config` for database connection strings or other environment-specific settings before running in a new environment.
- Consider unit tests and CI to validate changes; there are no unit tests in the repo yet.

## How to contribute
- Fork, add a branch, implement changes, then submit a PR. Keep UI logic separated from data access where possible.

## License
- No license is included. Add a LICENSE file to clarify usage rights.
