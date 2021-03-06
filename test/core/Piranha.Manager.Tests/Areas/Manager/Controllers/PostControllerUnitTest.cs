/*
 * Copyright (c) 2016 Billy Wolfington
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 * 
 * https://github.com/piranhacms/piranha.core
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Piranha.Areas.Manager.Controllers;

namespace Piranha.Manager.Tests.Areas.Manager.Controllers
{
    public class PostControllerUnitTest : ManagerAreaControllerUnitTestBase<PostController>
    {
        protected override PostController SetupController() {
            return new PostController(mockApi.Object);
        }
    }
}
