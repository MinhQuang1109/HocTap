#include <stdio.h>
#include <string.h>

const int max = 100;
typedef struct{
	char hoTen[20];
	char maSinhvien[10];
	int namSinh;
	float dtb;
} SV;

typedef struct{
	int soSv;
	SV ds[100];
} DSSV;

void nhapSV(SV *s){
	fflush(stdin);
	printf("\nNhap ho ten: "); gets(s->hoTen);
	printf("Nhap ma sinh vien: "); gets(s->maSinhvien);
	printf("Nhap nam sinh: ");
	scanf("%d", &s->namSinh);
	printf("Nhap diem trung binh: ");
	scanf("%f", &s->dtb);
	printf("\n");
}

void inSV(SV s){
	printf("%s %s %d %0.2f\n", s.hoTen, s.maSinhvien, s.namSinh, s.dtb);
}

void nhapDSSV(DSSV *s){
	for(int i = 0; i < s->soSv; i++){
		nhapSV(&s->ds[i]);
	}
}

void inDSSV(DSSV s){
	for(int i = 0; i < s.soSv; i++){
		inSV(s.ds[i]);
	}
}

/*void lietKe(DSSV *s){
	printf("Danh sach sinh vien co dtb >= 8: \n");
	for(int i = 0; i < s->soSv; i++){
		if(s->ds[i].dtb >= 8)
			inSV(s->ds[i]);
	}
}*/

void them(DSSV *s, SV x, int k){
	printf("\nNhap sinh vien can them ");
	nhapSV(&x);
	printf("\nNhap vi tri them : ");
	scanf("%d", &k);
	if(s->soSv < max && k <= s->soSv){
		for(int i = s->soSv - 1; i >= k; i--)
			s->ds[i+1] = s->ds[i];
		s->ds[k] = x;
		s->soSv++;	
	}
	inDSSV(*s);
}

void xoa(DSSV *s, int c){
	printf("\nNhap vi tri sinh vien can xoa: ");
	scanf("%d", &c);
	if(s->soSv>0 && c<s->soSv){
		for(int i = c+1; i <= s->soSv-1; i++)
			s->ds[i-1] = s->ds[i];
		s->soSv--;
	}
	inDSSV(*s);
}







main()
{
	SV s[100], x;
	DSSV ds;
	int soSv, k, c;
	printf("So sinh vien: ");
	scanf("%d", &ds.soSv);
	nhapDSSV(&ds);
	inDSSV(ds);
	
	//lietKe(&ds);
	//them(&ds, x, k);
	xoa(&ds, c);
	
}
