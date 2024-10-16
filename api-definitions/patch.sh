#!/bin/sh

ctbeta="microsoft-graph/common-types/beta"

jq '(.fields[] | select (.jsonName == "identitySources") .readOnly) = false' ${ctbeta}/Model-ConnectedOrganization.json | sponge ${ctbeta}/Model-ConnectedOrganization.json
jq '(.fields[] | select (.jsonName == "tenantId") .readOnly) = false' ${ctbeta}/Model-CrossTenantAccessPolicyConfigurationPartner.json | sponge ${ctbeta}/Model-CrossTenantAccessPolicyConfigurationPartner.json
jq '(.fields[] | select (.jsonName == "lastModifiedBy") .readOnly) = true' ${ctbeta}/Model-UnifiedRoleManagementPolicy.json | sponge ${ctbeta}/Model-UnifiedRoleManagementPolicy.json
jq '(.fields[] | select (.jsonName == "lastModifiedDateTime") .readOnly) = true' ${ctbeta}/Model-UnifiedRoleManagementPolicy.json | sponge ${ctbeta}/Model-UnifiedRoleManagementPolicy.json
