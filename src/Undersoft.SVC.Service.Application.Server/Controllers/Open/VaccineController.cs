﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.SDK.Service;

namespace Undersoft.SVC.Service.Application.Server.Controllers.Open;

using Undersoft.SDK.Service.Server.Controller.Open;
using Undersoft.SVC.Service.Clients.Abstractions;
using Undersoft.SVC.Service.Contracts.Catalogs;

public class VaccineController
    : OpenDataRemoteController<long, ICatalogsStore, Vaccine, Vaccine, ServiceManager>
{
    public VaccineController(IServicer servicer) : base(servicer) { }
}
