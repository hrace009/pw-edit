type = struct NPC_ESSENCE {
    unsigned int id;
    namechar name[32];
    unsigned int id_type;
    float refresh_time;
    unsigned int attack_rule;
    char file_model[128];
    float tax_rate;
    unsigned int id_src_monster;
    namechar hello_msg[256];
    unsigned int id_to_discover;
    unsigned int domain_related;
    unsigned int id_talk_service;
    unsigned int id_sell_service;
    unsigned int id_buy_service;
    unsigned int id_repair_service;
    unsigned int id_install_service;
    unsigned int id_uninstall_service;
    unsigned int id_task_out_service;
    unsigned int id_task_in_service;
    unsigned int id_task_matter_service;
    unsigned int id_skill_service;
    unsigned int id_heal_service;
    unsigned int id_transmit_service;
    unsigned int id_transport_service;
    unsigned int id_proxy_service;
    unsigned int id_storage_service;
    unsigned int id_make_service;
    unsigned int id_decompose_service;
    unsigned int id_identify_service;
    unsigned int id_war_towerbuild_service;
    unsigned int id_resetprop_service;
    unsigned int id_petname_service;
    unsigned int id_petlearnskill_service;
    unsigned int id_petforgetskill_service;
    unsigned int id_equipbind_service;
    unsigned int id_equipdestroy_service;
    unsigned int id_equipundestroy_service;
    unsigned int combined_services;
    unsigned int id_mine;
}
