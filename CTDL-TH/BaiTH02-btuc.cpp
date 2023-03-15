#include <stdio.h>
#include <string.h>

const int max =100;
typedef struct{
	char hoTen[20];
	int namSinh;
	float dtb;
}SV;

typedef struct{
	int n;
	SV ds[100];
}DSSV;


void nhapSV(SV *s){
	fflush(stdin);
	printf("Nhap ho ten: ");gets(s->hoTen);
	printf("Nhap nam sinh: ");
	scanf("%d", &s->namSinh);
	printf("Nhap dtb: ");
	scanf("%f", &s->dtb);
}

void xuatSV(SV s){
	printf("\n%s %d %.2f", s.hoTen, s.namSinh, s.dtb);
}

void nhapMangSV(DSSV *s){
	for(int i =0; i < s->n; i++){
		nhapSV(&s->ds[i]);
	}
}

void xuatMangSV(DSSV &s){
	for(int i =0; i < s.n; i++){
		xuatSV(s.ds[i]);
	}
}

int dem(DSSV *s){
	int dem = 0;
	for(int i = 0; i<s->n; i++){
		if(s->ds[i].dtb>=8)
			dem++;
	}
	return dem;
}

void xoa(DSSV *s, int k){
	if(s->n>0 && k<s->n){
		for(int i=k+1; i<=s->n-1;i++)
			s->ds[i-1]=s->ds[i];
		s->n--;
	}
	xuatMangSV(*s);
}

void mangMoi(DSSV *s, DSSV r){
	r.n=0;
	for(int i = 0; i<s->n; i++){
		if(s->ds[i].dtb >= 8.0){
			r.ds[r.n++] = s->ds[i];
		}	
	}
	printf("\nDs sinh vien co dtb >= 8.0 la: ");
	
	xuatMangSV(r);
}


void them(DSSV *s, SV x, int k){
	nhapSV(&x); 
	if(s->n<max && k<=s->n){
		for(int i =s->n-1; i>=k; i--)
			s->ds[i+1]=s->ds[i];
		s->ds[k] = x;
		s->n++;
	}
	xuatMangSV(*s);
}

/*
void giamDan(DSSV *s){
	for(int i=0; i<=s->n-1;i++){
		for(int j=i+1; j<s->n;j++){
			if(s->ds[i].dtb < s->ds[j].dtb){
				SV tmp = s->ds[i];
				s->ds[i] = s->ds[j];
				s->ds[j] = tmp;
			}
		}
	}
	xuatMangSV(*s);
}
*/

/*void  demHoNguyen(DSSV *s){
	int dem = 0;
	for(int i = 0; i<s->n; i++){
		if(s->ds[i].hoTen='Nguyen')
			dem++;
	}
}*/
 
main(){
	SV s[100], a[100], b[100], m;
	DSSV ds;
	DSSV dss;
	SV x; 
	int n, k;
	printf("Nhap n: ");
	scanf("%d", &ds.n);
	nhapMangSV(&ds);
	xuatMangSV(ds);
	printf("\nSo sv co dtb>=8 la: %d",dem(&ds));
	xoa(&ds, 2);
	mangMoi(&ds, dss);
	giamDan(&ds);
	them(&ds, x, k); 
}
