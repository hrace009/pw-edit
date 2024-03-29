type = struct TASKDICE_ESSENCE {
    unsigned int id;
    namechar name[32];
    char file_matter[128];
    char file_icon[128];
    struct {
        unsigned int id;
        float probability;
    } task_lists[8];
    unsigned int use_on_pick;
    int pile_num_max;
    unsigned int has_guid;
    unsigned int proc_type;
}
