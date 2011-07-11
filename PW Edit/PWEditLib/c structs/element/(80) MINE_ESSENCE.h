type = struct MINE_ESSENCE {
    unsigned int id;
    unsigned int id_type;
    namechar name[32];
    unsigned int level;
    unsigned int level_required;
    unsigned int id_equipment_required;
    unsigned int eliminate_tool;
    unsigned int time_min;
    unsigned int time_max;
    int exp;
    int skillpoint;
    char file_model[128];
    struct {
        unsigned int id;
        float probability;
    } materials[16];
    int num1;
    float probability1;
    int num2;
    float probability2;
    unsigned int task_in;
    unsigned int task_out;
    unsigned int uninterruptable;
    struct {
        unsigned int id_monster;
        int num;
        float radius;
    } npcgen[4];
    struct {
        unsigned int monster_faction;
        float radius;
        int num;
    } aggros[1];
    unsigned int permenent;
}
