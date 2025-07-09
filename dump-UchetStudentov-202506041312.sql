--
-- PostgreSQL database dump
--

-- Dumped from database version 16.6
-- Dumped by pg_dump version 16.6

-- Started on 2025-06-04 13:12:09

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- TOC entry 4 (class 2615 OID 2200)
-- Name: public; Type: SCHEMA; Schema: -; Owner: pg_database_owner
--

CREATE SCHEMA public;


ALTER SCHEMA public OWNER TO pg_database_owner;

--
-- TOC entry 4874 (class 0 OID 0)
-- Dependencies: 4
-- Name: SCHEMA public; Type: COMMENT; Schema: -; Owner: pg_database_owner
--

COMMENT ON SCHEMA public IS 'standard public schema';


SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 218 (class 1259 OID 16407)
-- Name: group; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."group" (
    id integer NOT NULL,
    short_name character varying(6) NOT NULL,
    code integer NOT NULL,
    create_date date NOT NULL,
    speciality_id integer,
    tutor_id integer
);


ALTER TABLE public."group" OWNER TO postgres;

--
-- TOC entry 217 (class 1259 OID 16406)
-- Name: group_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.group_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.group_id_seq OWNER TO postgres;

--
-- TOC entry 4875 (class 0 OID 0)
-- Dependencies: 217
-- Name: group_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.group_id_seq OWNED BY public."group".id;


--
-- TOC entry 220 (class 1259 OID 16414)
-- Name: speciality; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.speciality (
    id integer NOT NULL,
    name character varying(50) NOT NULL,
    qualification character varying(50) NOT NULL,
    code integer NOT NULL,
    description character varying(50) NOT NULL
);


ALTER TABLE public.speciality OWNER TO postgres;

--
-- TOC entry 219 (class 1259 OID 16413)
-- Name: speciality_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.speciality_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.speciality_id_seq OWNER TO postgres;

--
-- TOC entry 4876 (class 0 OID 0)
-- Dependencies: 219
-- Name: speciality_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.speciality_id_seq OWNED BY public.speciality.id;


--
-- TOC entry 222 (class 1259 OID 16421)
-- Name: student; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.student (
    id integer NOT NULL,
    name character varying(50) NOT NULL,
    surname character varying(50) NOT NULL,
    patronymic character varying(50) NOT NULL,
    phone_number character varying(15) NOT NULL,
    email character varying(50) NOT NULL,
    admission_base character varying(10) NOT NULL,
    address character varying(50) NOT NULL,
    record_book_number integer NOT NULL,
    certificate_code integer NOT NULL,
    passport_number integer NOT NULL,
    password character varying(30) NOT NULL,
    group_id integer
);


ALTER TABLE public.student OWNER TO postgres;

--
-- TOC entry 221 (class 1259 OID 16420)
-- Name: student_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.student_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.student_id_seq OWNER TO postgres;

--
-- TOC entry 4877 (class 0 OID 0)
-- Dependencies: 221
-- Name: student_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.student_id_seq OWNED BY public.student.id;


--
-- TOC entry 216 (class 1259 OID 16400)
-- Name: tutor; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tutor (
    id integer NOT NULL,
    name character varying(50) NOT NULL,
    surname character varying(50) NOT NULL,
    patronymic character varying(50),
    phone_number character varying(15) NOT NULL,
    email character varying(50)
);


ALTER TABLE public.tutor OWNER TO postgres;

--
-- TOC entry 215 (class 1259 OID 16399)
-- Name: tutor_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tutor_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tutor_id_seq OWNER TO postgres;

--
-- TOC entry 4878 (class 0 OID 0)
-- Dependencies: 215
-- Name: tutor_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tutor_id_seq OWNED BY public.tutor.id;


--
-- TOC entry 4704 (class 2604 OID 16410)
-- Name: group id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."group" ALTER COLUMN id SET DEFAULT nextval('public.group_id_seq'::regclass);


--
-- TOC entry 4705 (class 2604 OID 16417)
-- Name: speciality id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.speciality ALTER COLUMN id SET DEFAULT nextval('public.speciality_id_seq'::regclass);


--
-- TOC entry 4706 (class 2604 OID 16424)
-- Name: student id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.student ALTER COLUMN id SET DEFAULT nextval('public.student_id_seq'::regclass);


--
-- TOC entry 4703 (class 2604 OID 16403)
-- Name: tutor id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tutor ALTER COLUMN id SET DEFAULT nextval('public.tutor_id_seq'::regclass);


--
-- TOC entry 4864 (class 0 OID 16407)
-- Dependencies: 218
-- Data for Name: group; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."group" VALUES (24, 'IS-40', 1, '2024-09-01', 1, 10);
INSERT INTO public."group" VALUES (61, 'П-11', 3333, '2024-09-01', 9, 14);
INSERT INTO public."group" VALUES (64, 'ГД-11', 5645, '2012-11-12', 12, 15);
INSERT INTO public."group" VALUES (65, 'ПК-10', 5455, '2024-09-01', 11, 16);
INSERT INTO public."group" VALUES (60, 'ПС-22', 123, '2012-11-12', 1, 13);


--
-- TOC entry 4866 (class 0 OID 16414)
-- Dependencies: 220
-- Data for Name: speciality; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.speciality VALUES (1, 'information systems and programming', 'programmer', 123, 'speciality add test');
INSERT INTO public.speciality VALUES (10, 'Графический дизайн', 'Граф.Дизайнер', 1232, 'desc');
INSERT INTO public.speciality VALUES (11, 'Право', 'Юрист', 6565, 'desc');
INSERT INTO public.speciality VALUES (12, 'Кондитерское дело', 'Повар-кондитер', 65656, 'desc');
INSERT INTO public.speciality VALUES (9, 'Банковское дело', 'Банкир', 123123, 'some desc');


--
-- TOC entry 4868 (class 0 OID 16421)
-- Dependencies: 222
-- Data for Name: student; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.student VALUES (35, 'Kirill', 'Kosnyrev', 'Sergeevich', '29982382383', '123', '11', 'Pushkina 1111', 1, 1, 1234, 'kirill1', 24);
INSERT INTO public.student VALUES (78, 'Ivan', 'Ivanov', 'ghjghj', '89000000000', 'ivanov@mail.com', '11', 'Morozova 40, 17', 123, 123, 123456789, 'ivanov123', 24);
INSERT INTO public.student VALUES (83, 'Ксения', 'Волкова', 'Денисовна', '254458731645', 'ponubu_tudi62@bk.ru', '11', 'rweggrg', 23434, 12313, 1231233, 'ythj67h65htyh', 24);
INSERT INTO public.student VALUES (84, 'Нина', 'Волкова', 'Вадимовна', '626378087524', 'lojo-cihaku71@hotmail.com', '11', 'rgegegrg', 34444, 131233, 123213, '56h65h56hhyh', 24);
INSERT INTO public.student VALUES (85, 'Роберт', 'Назаров', 'Дмитриевич', '564646546456', 'mey-utifamu51@aol.com', '11', 'ererrwrqw', 42123, 123132, 13213, '6h56yh56h', 24);
INSERT INTO public.student VALUES (86, 'Степан', 'Демидов', 'Артёмович', '174535311656', 'ravix-elama60@aol.com', '9', 'rgreger', 43434, 213123, 12313, 'h5h56yh5', 24);
INSERT INTO public.student VALUES (87, 'Даниил', 'Митрофанов', 'Леонидович', '456456456456', 'yih-uwoniwe84@inbox.ru', '11', 'sdfsdfdv', 23445, 1231231, 213123, '56h56h5', 24);
INSERT INTO public.student VALUES (88, 'Анна', 'Петрова', 'Марковна', '456546546466', 'veji-zitagu16@inbox.ru', '9', 'fdfdsf', 54545, 123123, 1313, '6h56h56h', 24);
INSERT INTO public.student VALUES (89, 'Леонид', 'Дмитриев', 'Кириллович', '456464666564', 'wihiwep_oso1@mail.ru', '9', 'gfgfgdg', 44444, 32131, 312313, 'h56y5h', 24);
INSERT INTO public.student VALUES (90, 'Роман', 'Новиков', 'Дмитриевич', '840844633886', 'bahab-isuke37@yahoo.com', '9', 'fgdfgdf', 23432, 23123, 123123, '56h56h56h', 24);
INSERT INTO public.student VALUES (91, 'Фёдор', 'Беликов', 'Борисович', '308933354436', 'xogiz-idawa24@mail.ru', '11', 'dfgdfgg', 34535, 12313, 234324, '56h56y56', 24);
INSERT INTO public.student VALUES (92, 'Егор', 'Куприянов', 'Артёмович', '456465464656', 'zanag_ujuvo34@gmail.com', '9', 'gdfgsdfsd', 35353, 123123, 31312, '23ffh', 24);
INSERT INTO public.student VALUES (93, 'Святослав', 'Соколов', 'Александрович', '149044888328', 'jewep_otope35@bk.ru', '9', 'fdsfsd', 23443, 123123, 42334, '454h4', 24);
INSERT INTO public.student VALUES (94, 'Мария', 'Соколова', 'Михайловна', '757111964157', 'faju_bepimo57@internet.ru', '9', 'dfff', 43243, 123123, 34342, 'g22fg', 24);
INSERT INTO public.student VALUES (95, 'Савелий', 'Смирнов', 'Михайлович', '107513057217', 'hiv_epufive1@mail.ru', '11', 'sfsfsffsf', 23431, 12312, 43242, '56h56yh', 24);
INSERT INTO public.student VALUES (96, 'Яна', 'Волкова', 'Тимуровна', '867868768768', 'mabo_rikolo63@list.ru', '11', 'dfsdfsf', 43434, 123123, 4234, 'h676', 24);
INSERT INTO public.student VALUES (97, 'Елизавета', 'Медведева', 'Дмитриевна', '678678678768', 'kuh_iwutuce39@hotmail.com', '11', 'hfghfghfgh', 34234, 13123, 2343234, 'g445t', 24);


--
-- TOC entry 4862 (class 0 OID 16400)
-- Dependencies: 216
-- Data for Name: tutor; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tutor VALUES (10, 'Dmitry', 'Yakovlev', 'Vadimovich', '8989898989', '123');
INSERT INTO public.tutor VALUES (13, 'Асия', 'Новикова', 'Степановна', '859435385455', 'woforag-owu98@yandex.ru');
INSERT INTO public.tutor VALUES (14, 'Варвара', 'Демина', 'Михайловна', '123131231233', 'ruv-alivuja31@mail.ru');
INSERT INTO public.tutor VALUES (15, 'Алиса', 'Иванова', 'Тимофеевна', '324242344444', 'sipej_omehu11@inbox.ru');
INSERT INTO public.tutor VALUES (16, 'Никита', 'Макаров', 'Маркович', '768767867866', 'koxe_sehido3@yahoo.com');
INSERT INTO public.tutor VALUES (17, 'Полина', 'Рыбакова', 'Ивановна', '767687676767', 'curarod-ifu51@mail.ru');


--
-- TOC entry 4879 (class 0 OID 0)
-- Dependencies: 217
-- Name: group_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.group_id_seq', 65, true);


--
-- TOC entry 4880 (class 0 OID 0)
-- Dependencies: 219
-- Name: speciality_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.speciality_id_seq', 12, true);


--
-- TOC entry 4881 (class 0 OID 0)
-- Dependencies: 221
-- Name: student_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.student_id_seq', 97, true);


--
-- TOC entry 4882 (class 0 OID 0)
-- Dependencies: 215
-- Name: tutor_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tutor_id_seq', 17, true);


--
-- TOC entry 4710 (class 2606 OID 16412)
-- Name: group group_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."group"
    ADD CONSTRAINT group_pk PRIMARY KEY (id);


--
-- TOC entry 4712 (class 2606 OID 16419)
-- Name: speciality speciality_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.speciality
    ADD CONSTRAINT speciality_pk PRIMARY KEY (id);


--
-- TOC entry 4714 (class 2606 OID 16426)
-- Name: student student_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.student
    ADD CONSTRAINT student_pk PRIMARY KEY (id);


--
-- TOC entry 4708 (class 2606 OID 16405)
-- Name: tutor tutor_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tutor
    ADD CONSTRAINT tutor_pk PRIMARY KEY (id);


--
-- TOC entry 4715 (class 2606 OID 16518)
-- Name: group group_speciality_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."group"
    ADD CONSTRAINT group_speciality_fk FOREIGN KEY (speciality_id) REFERENCES public.speciality(id) ON UPDATE CASCADE ON DELETE SET NULL;


--
-- TOC entry 4716 (class 2606 OID 16513)
-- Name: group group_tutor_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."group"
    ADD CONSTRAINT group_tutor_fk FOREIGN KEY (tutor_id) REFERENCES public.tutor(id) ON UPDATE CASCADE ON DELETE SET NULL;


--
-- TOC entry 4717 (class 2606 OID 16508)
-- Name: student student_group_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.student
    ADD CONSTRAINT student_group_fk FOREIGN KEY (group_id) REFERENCES public."group"(id) ON UPDATE CASCADE ON DELETE SET NULL;


-- Completed on 2025-06-04 13:12:09

--
-- PostgreSQL database dump complete
--

