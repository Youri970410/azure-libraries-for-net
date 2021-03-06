// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Microsoft.Azure.Management.ContainerInstance.Fluent.ContainerGroup.Update
{
    /// <summary>
    /// The template for an update operation, containing all the settings that can be modified.
    /// </summary>
    public interface IUpdate :
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.Resource.Update.IUpdateWithTags<Microsoft.Azure.Management.ContainerInstance.Fluent.ContainerGroup.Update.IUpdate>,
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.ResourceActions.IAppliable<Microsoft.Azure.Management.ContainerInstance.Fluent.IContainerGroup>
    {

    }
}