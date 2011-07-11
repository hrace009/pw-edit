type = struct talk_proc::window {
    unsigned int id;
    unsigned int id_parent;
    int talk_text_len;
    namechar *talk_text;
    int num_option;
    talk_proc::option *options;
  public:
    void window(void);
    ~window(int);
    int save(FILE *);
    int load(FILE *);
}
