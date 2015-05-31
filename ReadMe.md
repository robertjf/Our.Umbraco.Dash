# Our.Umbraco.Dash - Dashboard customisation and control
Provides a centralised point for managing Dashboards with plugins and customisations.

## Goals
* Extensible Architecture - allow creation of additional plugins
* Import existing Dashboard configuration file
* Upload images, stylesheets etc. for customistation
  * Think about customising the default Content Dashboard to tailor the presentation around a company's brand style guide
* Dashboards should be user-customisable.
* Some sections will be mandatory, while others can be added/removed in user-preferences.
* Persist preferences on the server (associated with the User)

## Plugins
This section describes a possible list of dashboard plugins
* Plugins should be User-aware.  They should take into account permissions.

### Content 
* List of content edited - sortable by times edited, last updated, etc.
* Content Submissions Status - if Content Writer, has the item been published by an Editor
* Upcoming Content to be published/unpublished based on schedule
* Organisation Dashboard
  * Support - support options

### Member
* List of new Members by Type and Group
* MemberManagement Dashboard integration
* Member Lockouts

### Developer
* Report Exception/Issue integrate with Issue tracker
* Track Issues
* Upgrade Notifications including changelog

### Personalisation
* Manage Personal settings - this might fall under the Content Node; but perhaps we can plug into the pull-out for Personal info?

### Help
* Custom Help content (from the Help icon) in the Help Pullout
  * Support Contact Information




*Note to self - Markdown reference:* [help.github.com/articles/markdown-basics/](Markdown Basics)