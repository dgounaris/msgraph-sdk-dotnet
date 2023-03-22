---
title: "Create definitions"
description: "Create a new accessReviewScheduleDefinition object."
ms.localizationpriority: medium
author: isabelleatmsft
ms.prod: "governance"
doc_type: apiPageType
---

# Create definitions

Namespace: microsoft.graph

Create a new [accessReviewScheduleDefinition](../resources/accessreviewscheduledefinition.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type                        | Permissions (from least to most privileged)              |
|:--------------------------------------|:---------------------------------------------------------|
|Delegated (work or school account)     | AccessReview.ReadWrite.All  |
|Delegated (personal Microsoft account)|Not supported.|
|Application                            | AccessReview.ReadWrite.All |

The signed-in user must also be in a directory role that permits them to create an access review.  For more details, see the role and permission requirements for [access reviews](../resources/accessreviewsv2-overview.md).

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /identityGovernance/accessReviews/definitions
```
## Request headers
| Name         | Description |
|:-------------|:------------|
|Authorization|Bearer {token}. Required.|
| Content-type | application/json. Required. |

## Request body
In the request body, supply a JSON representation of an [accessReviewScheduleDefinition](../resources/accessreviewscheduledefinition.md) object.

The following table shows the properties accepted to create an accessReview.

| Property | Type | Description |
|:-------------|:------------|:------------|
| additionalNotificationRecipients   |[accessReviewNotificationRecipientItem](../resources/accessReviewNotificationRecipientItem.md) collection| Defines the list of additional users or group members to be notified of the access review progress. |
| descriptionForAdmins | String | Context of the review provided to admins. Required. |
| descriptionForReviewers | String | Context of the review provided to reviewers in email notifications. Email notifications support up to 256 characters. Required. |
| displayName | String | Name of access review series. Required.|
| fallbackReviewers |[accessReviewReviewerScope](../resources/accessreviewreviewerscope.md) collection|If provided, the fallback reviewers are asked to complete a review if the primary reviewers do not exist. For example, if managers are selected as `reviewers` and a principal under review does not have a manager in Azure AD, the fallback reviewers are asked to review that principal. <br/><br/>**NOTE:** The value of this property will be ignored if fallback reviewers are assigned through the **stageSettings** property.|
| instanceEnumerationScope | [accessReviewScope](../resources/accessreviewscope.md) | In the case of an all groups review, this determines the scope of which groups will be reviewed. See [accessReviewScope](../resources/accessreviewscope.md) and also learn how to [configure the scope of your access review definition](/graph/accessreviews-scope-concept).| 
| reviewers | [accessReviewReviewerScope](../resources/accessreviewreviewerscope.md) collection | Defines who the reviewers are. If none are specified, the review is a self-review (users review their own access).  For examples of options for assigning reviewers, see [Assign reviewers to your access review definition using the Microsoft Graph API](/graph/accessreviews-reviewers-concept). <br/><br/>**NOTE:** The value of this property will be ignored if reviewers are assigned through the **stageSettings** property. |
| scope | [accessReviewScope](../resources/accessreviewscope.md) | Defines the entities whose access is reviewed. See  [accessReviewScope](../resources/accessreviewscope.md) and also learn how to [configure the scope of your access review definition](/graph/accessreviews-scope-concept). Required.| 
|stageSettings|[accessReviewStageSettings](../resources/accessreviewstagesettings.md) collection| Defines how many stages each instance of an access review series will have. Stages will be created sequentially based on the **dependsOn** property. Each stage can have different set of reviewer, fallback reviewers and settings. <br/><br/>When this property is defined, its values are used instead of the corresponding values in the [accessReviewScheduleDefinition](../resources/accessreviewscheduledefinition.md) object and its **settings** property. Optional. |
| settings | [accessReviewScheduleSettings](../resources/accessreviewschedulesettings.md)| The settings for an access review series. Recurrence is determined here. See [accessReviewScheduleSettings](../resources/accessreviewschedulesettings.md). |

## Response
If successful, this method returns a `201 Created` response code and an [accessReviewScheduleDefinition](../resources/accessreviewscheduledefinition.md) object in the response body.

## Examples

### Example 1: Create an access review on a group

The following example creates an access review with the following settings:
+ The review reviews all members of a group with the **id** `02f3bafb-448c-487c-88c2-5fd65ce49a41`.
+ A specific user with the user **id** `398164b1-5196-49dd-ada2-364b49f99b27` is the reviewer.
+ It recurs weekly and continues indefinitely.

#### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_accessReviewScheduleDefinition"
}-->
```http
POST https://graph.microsoft.com/v1.0/identityGovernance/accessReviews/definitions
Content-type: application/json

{
  "displayName": "Test create",
  "descriptionForAdmins": "New scheduled access review",
  "descriptionForReviewers": "If you have any questions, contact jerry@contoso.com",
  "scope": {
    "@odata.type": "#microsoft.graph.accessReviewQueryScope",
    "query": "/groups/02f3bafb-448c-487c-88c2-5fd65ce49a41/transitiveMembers",
    "queryType": "MicrosoftGraph"
  },
  "reviewers": [
    {
      "query": "/users/398164b1-5196-49dd-ada2-364b49f99b27",
      "queryType": "MicrosoftGraph"
    }
  ],  
  "settings": {
    "mailNotificationsEnabled": true,
    "reminderNotificationsEnabled": true,
    "justificationRequiredOnApproval": true,
    "defaultDecisionEnabled": false,
    "defaultDecision": "None",
    "instanceDurationInDays": 1,
    "recommendationsEnabled": true,
    "recurrence": {
      "pattern": {
        "type": "weekly",
        "interval": 1
      },
      "range": {
        "type": "noEnd",
        "startDate": "2020-09-08T12:02:30.667Z"
      }
    }
  }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var accessReviewScheduleDefinition = new AccessReviewScheduleDefinition
{
	DisplayName = "Test create",
	DescriptionForAdmins = "New scheduled access review",
	DescriptionForReviewers = "If you have any questions, contact jerry@contoso.com",
	Scope = new AccessReviewQueryScope
	{
		Query = "/groups/02f3bafb-448c-487c-88c2-5fd65ce49a41/transitiveMembers",
		QueryType = "MicrosoftGraph"
	},
	Reviewers = new List<AccessReviewReviewerScope>()
	{
		new AccessReviewReviewerScope
		{
			Query = "/users/398164b1-5196-49dd-ada2-364b49f99b27",
			QueryType = "MicrosoftGraph"
		}
	},
	Settings = new AccessReviewScheduleSettings
	{
		MailNotificationsEnabled = true,
		ReminderNotificationsEnabled = true,
		JustificationRequiredOnApproval = true,
		DefaultDecisionEnabled = false,
		DefaultDecision = "None",
		InstanceDurationInDays = 1,
		RecommendationsEnabled = true,
		Recurrence = new PatternedRecurrence
		{
			Pattern = new RecurrencePattern
			{
				Type = RecurrencePatternType.Weekly,
				Interval = 1
			},
			Range = new RecurrenceRange
			{
				Type = RecurrenceRangeType.NoEnd,
				StartDate = new Date(2020,9,8)
			}
		}
	}
};

await graphClient.IdentityGovernance.AccessReviews.Definitions
	.Request()
	.AddAsync(accessReviewScheduleDefinition);

```


 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.accessReviewScheduleDefinition"
} -->
```http
HTTP/1.1 201 Created
Content-type: application/json

{
  "id": "29f2d16e-9ca6-4052-bbfe-802c48944448",
  "displayName": "Test create",
  "createdDateTime": "0001-01-01T00:00:00Z",
  "lastModifiedDateTime": "0001-01-01T00:00:00Z",
  "status": "NotStarted",
  "descriptionForAdmins": "Test create",
  "descriptionForReviewers": "Test create",
  "instanceEnumerationScope": null,
  "createdBy": {
    "id": "957f1027-c0ee-460d-9269-b8444459e0fe",
    "displayName": "MOD Administrator",
    "userPrincipalName": "admin@contoso.com"
  },
  "scope": {
    "@odata.type": "#microsoft.graph.accessReviewQueryScope",
    "query": "/groups/b74444cb-038a-4802-8fc9-b9d1ed0cf11f/transitiveMembers",
    "queryType": "MicrosoftGraph"
  },
  "reviewers": [
    {
      "query": "/users/7eae986b-d425-48b2-adf2-3c777f4444f3",
      "queryType": "MicrosoftGraph",
      "queryRoot": "decisions"
    }
  ],  
  "settings": {
    "mailNotificationsEnabled": true,
    "reminderNotificationsEnabled": true,
    "justificationRequiredOnApproval": true,
    "defaultDecisionEnabled": false,
    "defaultDecision": "None",
    "instanceDurationInDays": 1,
    "autoApplyDecisionsEnabled": false,
    "recommendationsEnabled": true,
    "recurrence": {
      "pattern": {
        "type": "weekly",
        "interval": 1,
        "month": 0,
        "dayOfMonth": 0,
        "daysOfWeek": [],
        "firstDayOfWeek": "sunday",
        "index": "first"
      },
      "range": {
        "type": "noEnd",
        "numberOfOccurrences": 0,
        "recurrenceTimeZone": null,
        "startDate": "2020-09-08",
        "endDate": null
      }
    },
  "applyActions": []
  },
  "additionalNotificationRecipients": []
}
```

### Example 2: Create an access review on all teams with inactive guest users

The following example creates an access review with the following settings:
+ The review reviews all teams with inactive guest users. The period of inactivity is 30 days from the start date of the access review.
+ The group owners are the reviewers and fallback reviewers are assigned.
+ It recurs on the third day of every quarter and continues indefinitely.
+ **autoApplyDecisionsEnabled** is set to `true` with the **defaultDecision** set to `Deny`.

#### Request
In the request body, supply a JSON representation of the [accessReviewScheduleDefinition](../resources/accessreviewscheduledefinition.md) object.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_accessReviewScheduleDefinition_inactiveguests_M365"
}-->
```http
POST https://graph.microsoft.com/v1.0/identityGovernance/accessReviews/definitions
Content-type: application/json

{
  "displayName": "Review inactive guests on teams",
  "descriptionForAdmins": "Control guest user access to our teams.",
  "descriptionForReviewers": "Information security is everyone's responsibility. Review our access policy for more.",
  "instanceEnumerationScope": {
    "@odata.type": "#microsoft.graph.accessReviewQueryScope",
    "query": "/groups?$filter=(groupTypes/any(c:c+eq+'Unified') and resourceProvisioningOptions/Any(x:x eq 'Team')')",
    "queryType": "MicrosoftGraph"
  },
  "scope": {
    "@odata.type": "#microsoft.graph.accessReviewInactiveUsersQueryScope",
    "query": "./members/microsoft.graph.user/?$filter=(userType eq 'Guest')",
    "queryType": "MicrosoftGraph",
    "inactiveDuration": "P30D"
    },
  "reviewers": [
    {
      "query": "./owners",
      "queryType": "MicrosoftGraph"
    }
  ],
  "fallbackReviewers": [
    {
      "query": "/users/fc9a2c2b-1ddc-486d-a211-5fe8ca77fa1f",
      "queryType": "MicrosoftGraph"
    }
  ],
  "settings": {
    "mailNotificationsEnabled": true,
    "reminderNotificationsEnabled": true,
    "justificationRequiredOnApproval": true,
    "recommendationsEnabled": true,
    "instanceDurationInDays": 3,
    "recurrence": {
      "pattern": {
        "type": "absoluteMonthly",
        "dayOfMonth": 5,
        "interval": 3
      },
      "range": {
        "type": "noEnd",
        "startDate": "2020-05-04T00:00:00.000Z"
      }
    },
    "defaultDecisionEnabled": true,
    "defaultDecision": "Deny",
    "autoApplyDecisionsEnabled": true
  }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var accessReviewScheduleDefinition = new AccessReviewScheduleDefinition
{
	DisplayName = "Review inactive guests on teams",
	DescriptionForAdmins = "Control guest user access to our teams.",
	DescriptionForReviewers = "Information security is everyone's responsibility. Review our access policy for more.",
	InstanceEnumerationScope = new AccessReviewQueryScope
	{
		Query = "/groups?$filter=(groupTypes/any(c:c+eq+'Unified') and resourceProvisioningOptions/Any(x:x eq 'Team')')",
		QueryType = "MicrosoftGraph"
	},
	Scope = new AccessReviewInactiveUsersQueryScope
	{
		Query = "./members/microsoft.graph.user/?$filter=(userType eq 'Guest')",
		QueryType = "MicrosoftGraph",
		InactiveDuration = new Duration("P30D")
	},
	Reviewers = new List<AccessReviewReviewerScope>()
	{
		new AccessReviewReviewerScope
		{
			Query = "./owners",
			QueryType = "MicrosoftGraph"
		}
	},
	FallbackReviewers = new List<AccessReviewReviewerScope>()
	{
		new AccessReviewReviewerScope
		{
			Query = "/users/fc9a2c2b-1ddc-486d-a211-5fe8ca77fa1f",
			QueryType = "MicrosoftGraph"
		}
	},
	Settings = new AccessReviewScheduleSettings
	{
		MailNotificationsEnabled = true,
		ReminderNotificationsEnabled = true,
		JustificationRequiredOnApproval = true,
		RecommendationsEnabled = true,
		InstanceDurationInDays = 3,
		Recurrence = new PatternedRecurrence
		{
			Pattern = new RecurrencePattern
			{
				Type = RecurrencePatternType.AbsoluteMonthly,
				DayOfMonth = 5,
				Interval = 3
			},
			Range = new RecurrenceRange
			{
				Type = RecurrenceRangeType.NoEnd,
				StartDate = new Date(2020,5,4)
			}
		},
		DefaultDecisionEnabled = true,
		DefaultDecision = "Deny",
		AutoApplyDecisionsEnabled = true
	}
};

await graphClient.IdentityGovernance.AccessReviews.Definitions
	.Request()
	.AddAsync(accessReviewScheduleDefinition);

```


 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.accessReviewScheduleDefinition"
} -->
```http
HTTP/1.1 201 Created
Content-type: application/json

{
  "@odata.context": "https://graph.microsoft.com/v1.0/$metadata#identityGovernance/accessReviews/definitions/$entity",
  "id": "b0966e21-a01e-43c9-8f8b-9ba30ed5710a",
  "displayName": "Review inactive guests on teams",
  "createdDateTime": "2021-05-04T18:27:02.6719849Z",
  "lastModifiedDateTime": "2021-05-04T18:27:24.0889623Z",
  "status": "InProgress",
  "descriptionForAdmins": "Control guest user access to our teams.",
  "descriptionForReviewers": "Information security is everyone's responsibility. Review our access policy for more.",
  "createdBy": {
    "id": "fc9a2c2b-1ddc-486d-a211-5fe8ca77fa1f",
    "displayName": "MOD Administrator",
    "userPrincipalName": "admin@contoso.com"
  },
  "scope": {
    "@odata.type": "#microsoft.graph.accessReviewInactiveUsersQueryScope",
    "query": "./members/microsoft.graph.user/?$count=true&$filter=(userType eq 'Guest')",
    "queryType": "MicrosoftGraph",
    "queryRoot": null,
    "inactiveDuration": "P30D"
  },
  "instanceEnumerationScope": {
    "@odata.type": "#microsoft.graph.accessReviewQueryScope",
    "query": "/groups?$filter=(groupTypes/any(c:c+eq+'Unified') and resourceProvisioningOptions/Any(x:x eq 'Team'))&$count=true",
    "queryType": "MicrosoftGraph",
    "queryRoot": null
  },
  "reviewers": [
    {
      "query": "./owners",
      "queryType": "MicrosoftGraph",
      "queryRoot": null
    }
  ],
  "backupReviewers": [
    {
      "query": "/users/fc9a2c2b-1ddc-486d-a211-5fe8ca77fa1f",
      "queryType": "MicrosoftGraph",
      "queryRoot": null
    }
  ],
  "fallbackReviewers": [
    {
      "query": "/users/fc9a2c2b-1ddc-486d-a211-5fe8ca77fa1f",
      "queryType": "MicrosoftGraph",
      "queryRoot": null
    }
  ],
  "settings": {
    "mailNotificationsEnabled": true,
    "reminderNotificationsEnabled": true,
    "justificationRequiredOnApproval": true,
    "defaultDecisionEnabled": true,
    "defaultDecision": "Deny",
    "instanceDurationInDays": 3,
    "autoApplyDecisionsEnabled": true,
    "recommendationsEnabled": true,
    "recurrence": {
      "pattern": {
        "type": "absoluteMonthly",
        "interval": 3,
        "month": 0,
        "dayOfMonth": 0,
        "daysOfWeek": [],
        "firstDayOfWeek": "sunday",
        "index": "first"
      },
      "range": {
        "type": "numbered",
        "numberOfOccurrences": 0,
        "recurrenceTimeZone": null,
        "startDate": "2021-05-05",
        "endDate": "9999-12-31"
      }
    },
    "applyActions": [
      {
        "@odata.type": "#microsoft.graph.removeAccessApplyAction"
      }
    ]
  },
  "additionalNotificationRecipients": []
}
```

### Example 3: Create an access review of all users to an application

The following example creates an access review with the following settings:
+ The review reviews user access to an application.
+ The people managers are the reviewers and fallback reviewers are the members of a group.
+ It recurs semi-annually and ends 1 year from the startDate.

#### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_accessReviewScheduleDefinition_allusers_M365_AADRole"
}-->
```http
POST https://graph.microsoft.com/v1.0/identityGovernance/accessReviews/definitions
Content-type: application/json

{
  "displayName": "Review employee access to LinkedIn",
  "descriptionForAdmins": "Review employee access to LinkedIn",
  "scope": {
    "@odata.type": "#microsoft.graph.principalResourceMembershipsScope",
    "principalScopes": [
      {
        "@odata.type": "#microsoft.graph.accessReviewQueryScope",
        "query": "/users",
        "queryType": "MicrosoftGraph"
      }
    ],
    "resourceScopes": [
      {
        "@odata.type": "#microsoft.graph.accessReviewQueryScope",
        "query": "/servicePrincipals/bae11f90-7d5d-46ba-9f55-8112b59d92ae",
        "queryType": "MicrosoftGraph"
      }
    ]
  },
  "reviewers": [
    {
      "query": "./manager",
      "queryType": "MicrosoftGraph",
      "queryRoot": "decisions"
    }
  ],
  "backupReviewers": [
    {
      "query": "/groups/072ac5f4-3f13-4088-ab30-0a276f3e6322/transitiveMembers",
      "queryType": "MicrosoftGraph"
    }
  ],
  "fallbackReviewers": [
    {
      "query": "/groups/072ac5f4-3f13-4088-ab30-0a276f3e6322/transitiveMembers",
      "queryType": "MicrosoftGraph"
    }
  ],
  "settings": {
    "mailNotificationsEnabled": true,
    "reminderNotificationsEnabled": true,
    "justificationRequiredOnApproval": true,
    "defaultDecisionEnabled": true,
    "defaultDecision": "Recommendation",
    "instanceDurationInDays": 180,
    "autoApplyDecisionsEnabled": true,
    "recommendationsEnabled": true,
    "recurrence": {
      "pattern": {
        "type": "absoluteMonthly",
        "interval": 6,
        "dayOfMonth": 0
      },
      "range": {
        "type": "numbered",
        "startDate": "2021-05-05",
        "endDate": "2022-05-05"
      }
    }
  }
}
```

# [C#](#tab/csharp)
```
Snippet not available
```

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.accessReviewScheduleDefinition"
} -->
```http
HTTP/1.1 201 Created
Content-type: application/json

{
  "@odata.context": "https://graph.microsoft.com/v1.0/$metadata#identityGovernance/accessReviews/definitions/$entity",
  "id": "1f79f34b-8667-40d9-875c-893b630b3dec",
  "scope": {
    "@odata.type": "#microsoft.graph.principalResourceMembershipsScope",
    "principalScopes": [
      {
        "@odata.type": "#microsoft.graph.accessReviewQueryScope",
        "query": "/users",
        "queryType": "MicrosoftGraph",
        "queryRoot": null
      }
    ],
    "resourceScopes": [
      {
        "@odata.type": "#microsoft.graph.accessReviewQueryScope",
        "query": "/servicePrincipals/bae11f90-7d5d-46ba-9f55-8112b59d92ae",
        "queryType": "MicrosoftGraph",
        "queryRoot": null
      }
    ]
  },
  "reviewers": [
    {
      "query": "./manager",
      "queryType": "MicrosoftGraph",
      "queryRoot": "decisions"
    }
  ],
  "backupReviewers": [
    {
      "query": "/groups/072ac5f4-3f13-4088-ab30-0a276f3e6322/transitiveMembers",
      "queryType": "MicrosoftGraph",
      "queryRoot": null
    }
  ],
  "fallbackReviewers": [
    {
      "query": "/groups/072ac5f4-3f13-4088-ab30-0a276f3e6322/transitiveMembers",
      "queryType": "MicrosoftGraph",
      "queryRoot": null
    }
  ],
  "settings": {
    "instanceDurationInDays": 180,
    "recurrence": {
      "pattern": {
        "type": "absoluteMonthly",
        "interval": 6,
        "month": 0,
        "dayOfMonth": 0,
        "daysOfWeek": [],
        "firstDayOfWeek": "sunday",
        "index": "first"
      },
      "range": {
        "type": "numbered",
        "numberOfOccurrences": 0,
        "recurrenceTimeZone": null,
        "startDate": "2021-05-05",
        "endDate": "2022-05-05"
      }
    }
  },
  "additionalNotificationRecipients": []
}
```

### Example 4: Create an access review on a group with multiple stages

The following example creates an access review with the following settings:
+ The review reviews all members of a group with the **id** `02f3bafb-448c-487c-88c2-5fd65ce49a41`.
+ It has two stages:
  + A specific user with the user **id** `398164b1-5196-49dd-ada2-364b49f99b27` is the reviewer for the first stage.
  + The people managers are the reviewers and fallback reviewers for the second stage.
+ It recurs weekly and continues indefinitely.

#### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_accessReviewScheduleDefinition_group_multiStage"
}-->
```http
POST https://graph.microsoft.com/v1.0/identityGovernance/accessReviews/definitions
Content-type: application/json

{
  "displayName": "Group Multi-stage Access Review",
  "descriptionForAdmins": "New scheduled access review",
  "descriptionForReviewers": "If you have any questions, contact jerry@contoso.com",
  "scope": {
    "@odata.type": "#microsoft.graph.accessReviewQueryScope",
    "query": "/groups/02f3bafb-448c-487c-88c2-5fd65ce49a41/transitiveMembers",
    "queryType": "MicrosoftGraph"
  },
  "stageSettings": [
    {
      "stageId": "1",
      "durationInDays": 2,
      "recommendationsEnabled": false,
      "decisionsThatWillMoveToNextStage": [
          "NotReviewed",
          "Approve"
      ],
      "reviewers": [
        {
          "query": "/users/398164b1-5196-49dd-ada2-364b49f99b27",
          "queryType": "MicrosoftGraph"
        }
      ]
    },
    {
      "stageId": "2",
      "dependsOn": [
          "1"
      ],
      "durationInDays": 2,
      "recommendationsEnabled": true,
      "reviewers": [
        {
          "query": "./manager",
          "queryType": "MicrosoftGraph",
          "queryRoot": "decisions"
        }
      ],
      "fallbackReviewers": [
        {
          "query": "/groups/072ac5f4-3f13-4088-ab30-0a276f3e6322/transitiveMembers",
          "queryType": "MicrosoftGraph"
        }
      ]
    }
  ],
  "settings": {
    "mailNotificationsEnabled": true,
    "reminderNotificationsEnabled": true,
    "justificationRequiredOnApproval": true,
    "defaultDecisionEnabled": false,
    "defaultDecision": "None",
    "instanceDurationInDays": 4,
    "recurrence": {
      "pattern": {
        "type": "weekly",
        "interval": 1
      },
      "range": {
        "type": "noEnd",
        "startDate": "2020-09-08T12:02:30.667Z"
      }
    },
    "decisionHistoriesForReviewersEnabled": true
  }
}

```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var accessReviewScheduleDefinition = new AccessReviewScheduleDefinition
{
	DisplayName = "Group Multi-stage Access Review",
	DescriptionForAdmins = "New scheduled access review",
	DescriptionForReviewers = "If you have any questions, contact jerry@contoso.com",
	Scope = new AccessReviewQueryScope
	{
		Query = "/groups/02f3bafb-448c-487c-88c2-5fd65ce49a41/transitiveMembers",
		QueryType = "MicrosoftGraph"
	},
	StageSettings = new List<AccessReviewStageSettings>()
	{
		new AccessReviewStageSettings
		{
			StageId = "1",
			DurationInDays = 2,
			RecommendationsEnabled = false,
			DecisionsThatWillMoveToNextStage = new List<String>()
			{
				"NotReviewed",
				"Approve"
			},
			Reviewers = new List<AccessReviewReviewerScope>()
			{
				new AccessReviewReviewerScope
				{
					Query = "/users/398164b1-5196-49dd-ada2-364b49f99b27",
					QueryType = "MicrosoftGraph"
				}
			}
		},
		new AccessReviewStageSettings
		{
			StageId = "2",
			DependsOn = new List<String>()
			{
				"1"
			},
			DurationInDays = 2,
			RecommendationsEnabled = true,
			Reviewers = new List<AccessReviewReviewerScope>()
			{
				new AccessReviewReviewerScope
				{
					Query = "./manager",
					QueryType = "MicrosoftGraph",
					QueryRoot = "decisions"
				}
			},
			FallbackReviewers = new List<AccessReviewReviewerScope>()
			{
				new AccessReviewReviewerScope
				{
					Query = "/groups/072ac5f4-3f13-4088-ab30-0a276f3e6322/transitiveMembers",
					QueryType = "MicrosoftGraph"
				}
			}
		}
	},
	Settings = new AccessReviewScheduleSettings
	{
		MailNotificationsEnabled = true,
		ReminderNotificationsEnabled = true,
		JustificationRequiredOnApproval = true,
		DefaultDecisionEnabled = false,
		DefaultDecision = "None",
		InstanceDurationInDays = 4,
		Recurrence = new PatternedRecurrence
		{
			Pattern = new RecurrencePattern
			{
				Type = RecurrencePatternType.Weekly,
				Interval = 1
			},
			Range = new RecurrenceRange
			{
				Type = RecurrenceRangeType.NoEnd,
				StartDate = new Date(2020,9,8)
			}
		},
		DecisionHistoriesForReviewersEnabled = true
	}
};

await graphClient.IdentityGovernance.AccessReviews.Definitions
	.Request()
	.AddAsync(accessReviewScheduleDefinition);

```


 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.accessReviewScheduleDefinition"
} -->
```http
HTTP/1.1 201 Created
Content-type: application/json

{
  "id": "29f2d16e-9ca6-4052-bbfe-802c48944448",
  "displayName": "Group Multi-stage Access Review",
  "createdDateTime": "0001-01-01T00:00:00Z",
  "lastModifiedDateTime": "0001-01-01T00:00:00Z",
  "status": "NotStarted",
  "descriptionForAdmins": "New scheduled access review",
  "descriptionForReviewers": "If you have any questions, contact jerry@contoso.com",
  "instanceEnumerationScope": null,
  "createdBy": {
    "id": "957f1027-c0ee-460d-9269-b8444459e0fe",
    "displayName": "MOD Administrator",
    "userPrincipalName": "admin@contoso.com"
  },
  "scope": {
    "@odata.type": "#microsoft.graph.accessReviewQueryScope",
    "query": "/groups/b74444cb-038a-4802-8fc9-b9d1ed0cf11f/transitiveMembers",
    "queryType": "MicrosoftGraph"
  },
  "stageSettings": [
    {
      "stageId": "1",
      "durationInDays": 2,
      "recommendationsEnabled": false,
      "decisionsThatWillMoveToNextStage": [
          "NotReviewed",
          "Approve"
      ],
      "reviewers": [
        {
          "query": "/users/398164b1-5196-49dd-ada2-364b49f99b27",
          "queryType": "MicrosoftGraph"
        }
      ]
    },
    {
      "stageId": "2",
      "dependsOn": [
          "1"
      ],
      "durationInDays": 2,
      "recommendationsEnabled": true,
      "reviewers": [
        {
          "query": "./manager",
          "queryType": "MicrosoftGraph",
          "queryRoot": "decisions"
        }
      ],
      "fallbackReviewers": [
        {
          "query": "/groups/072ac5f4-3f13-4088-ab30-0a276f3e6322/transitiveMembers",
          "queryType": "MicrosoftGraph"
        }
      ]
    }
  ], 
  "settings": {
    "mailNotificationsEnabled": true,
    "reminderNotificationsEnabled": true,
    "justificationRequiredOnApproval": true,
    "defaultDecisionEnabled": false,
    "defaultDecision": "None",
    "instanceDurationInDays": 1,
    "autoApplyDecisionsEnabled": false,
    "recommendationsEnabled": false,
    "recurrence": {
      "pattern": {
        "type": "weekly",
        "interval": 1,
        "month": 0,
        "dayOfMonth": 0,
        "daysOfWeek": [],
        "firstDayOfWeek": "sunday",
        "index": "first"
      },
      "range": {
        "type": "noEnd",
        "numberOfOccurrences": 0,
        "recurrenceTimeZone": null,
        "startDate": "2020-09-08",
        "endDate": null
      }
    },
    "decisionHistoriesForReviewersEnabled": true,
    "applyActions": []
  },
  "additionalNotificationRecipients": []
}
```

<!--
{
  "type": "#page.annotation",
  "description": "Create accessReviewScheduleDefinition",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->