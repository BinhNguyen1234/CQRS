CREATE TABLE AppUser (
    Id UUID PRIMARY KEY,
    last_name VARCHAR(255) NOT NULL,
    first_name VARCHAR(255) NOT NULL,
    hash_password TEXT NOT NULL,
    regist_user_id UUID NOT NULL,
    updated_user_id UUID NOT NULL,
    FOREIGN KEY (regist_user_id) REFERENCES AppUser(Id),
    FOREIGN KEY (updated_user_id) REFERENCES AppUser(Id),
    regist_date TIMESTAMPTZ  NOT NULL,
    updated_date TIMESTAMPTZ NOT NULL
);

CREATE TABLE message {
    Id UUID PRIMARY KEY,
    content varchar,
    reg
}