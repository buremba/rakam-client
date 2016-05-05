# Common files
require 'rakam_client/api_client'
require 'rakam_client/api_error'
require 'rakam_client/version'
require 'rakam_client/configuration'

# Models
require 'rakam_client/models/json_response'
require 'rakam_client/models/funnel_window'
require 'rakam_client/models/goal'
require 'rakam_client/models/continuous_query'
require 'rakam_client/models/user_search_users'
require 'rakam_client/models/measure'
require 'rakam_client/models/query_error'
require 'rakam_client/models/event_filter_aggregation'
require 'rakam_client/models/funnel_query'
require 'rakam_client/models/threshold'
require 'rakam_client/models/timeframe'
require 'rakam_client/models/collection_event'
require 'rakam_client/models/real_time_report'
require 'rakam_client/models/user_email_action_send'
require 'rakam_client/models/retention_action'
require 'rakam_client/models/scenario_step'
require 'rakam_client/models/variant'
require 'rakam_client/models/materialized_view_schema'
require 'rakam_client/models/execute_query'
require 'rakam_client/models/user_create_segment'
require 'rakam_client/models/collection'
require 'rakam_client/models/project_add_fields_to_schema'
require 'rakam_client/models/funnel_step'
require 'rakam_client/models/user'
require 'rakam_client/models/message'
require 'rakam_client/models/user_unset_property'
require 'rakam_client/models/real_time_query_result'
require 'rakam_client/models/query_result'
require 'rakam_client/models/set_user_properties'
require 'rakam_client/models/metadata_response'
require 'rakam_client/models/realtime_get'
require 'rakam_client/models/analyze_request'
require 'rakam_client/models/pre_calculated_table'
require 'rakam_client/models/user_merge_user'
require 'rakam_client/models/olap_table'
require 'rakam_client/models/ab_testing_report'
require 'rakam_client/models/user_increment_property'
require 'rakam_client/models/reference'
require 'rakam_client/models/user_context'
require 'rakam_client/models/serializable_action'
require 'rakam_client/models/email_action_config'
require 'rakam_client/models/event_filter'
require 'rakam_client/models/sorting'
require 'rakam_client/models/schema_field'
require 'rakam_client/models/automation_rule'
require 'rakam_client/models/event_context'
require 'rakam_client/models/user_email_action_batch'
require 'rakam_client/models/event_list'
require 'rakam_client/models/user_batch_create'
require 'rakam_client/models/mail_action'
require 'rakam_client/models/event'
require 'rakam_client/models/materialized_view'
require 'rakam_client/models/retention_query'
require 'rakam_client/models/user_mailbox_action_batch_send_messages'
require 'rakam_client/models/inline_response_200'

# APIs
require 'rakam_client/api/funnel_api'
require 'rakam_client/api/automation_api'
require 'rakam_client/api/user_api'
require 'rakam_client/api/abtesting_api'
require 'rakam_client/api/recipe_api'
require 'rakam_client/api/materializedview_api'
require 'rakam_client/api/admin_api'
require 'rakam_client/api/retention_api'
require 'rakam_client/api/useraction_api'
require 'rakam_client/api/realtime_api'
require 'rakam_client/api/usermailbox_api'
require 'rakam_client/api/continuousquery_api'
require 'rakam_client/api/event_api'
require 'rakam_client/api/eventexplorer_api'

module RakamClient
  class << self
    # Customize default settings for the SDK using block.
    #   RakamClient.configure do |config|
    #     config.username = "xxx"
    #     config.password = "xxx"
    #   end
    # If no block given, return the default Configuration object.
    def configure
      if block_given?
        yield(Configuration.default)
      else
        Configuration.default
      end
    end
  end
end
