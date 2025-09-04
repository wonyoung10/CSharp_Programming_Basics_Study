# 📚 C# Programming Basics Study

C# 기초 문법과 Windows Forms 실습을 중심으로 학습한 내용을 정리한 저장소입니다.  
콘솔/WinForms 프로젝트, 파일 탐색기 실습, 리스트뷰/트리뷰 등 **기본 컨트롤 활용**까지 폭넓게 다룹니다.

---

## 📦 레포 구조(Directories)

> 실제 폴더 이름 기준으로 간단 설명을 덧붙였습니다.  
> 예제 성격상 동명이인 폴더(예: `myMLApp`)가 여러 위치에 있을 수 있으며, 각 폴더 내 프로젝트는 독립적으로 실행되는 경우가 많습니다. :contentReference[oaicite:1]{index=1}

### 기본 문법/콘솔 관련
- **FirstApp** — 첫 C# 콘솔 앱 프로젝트(프로젝트 구조/빌드 파이프라인 이해에 적합). :contentReference[oaicite:2]{index=2}
- **Arithmetic** — 사칙연산 등 연산자/표현식 연습. :contentReference[oaicite:3]{index=3}
- **Array** — 배열 기초(선언/초기화/순회/기본 알고리즘). :contentReference[oaicite:4]{index=4}
- **Conditional** — 분기문( `if` / `switch` ) 기본 패턴. :contentReference[oaicite:5]{index=5}
- **loop** — 반복문(`for`/`while`/`do-while`/`foreach`) 패턴 연습. :contentReference[oaicite:6]{index=6}
- **Study** — 종합/복습 예제 모음(여러 개념 통합 실습). :contentReference[oaicite:7]{index=7}
- **class_copy** — 클래스/객체 복사 또는 클래스 구조 연습(추정). :contentReference[oaicite:8]{index=8}
- **number_list** — 숫자 목록 처리/정렬/검색 등의 콘솔 실습(추정). :contentReference[oaicite:9]{index=9}
- **number_db** — 숫자/간단 DB 또는 파일 저장 실습(추정). :contentReference[oaicite:10]{index=10}
- **test_DL** — 테스트용 프로젝트(이름상 임시/실험 코드). :contentReference[oaicite:11]{index=11}

### 파일/디렉토리 다루기
- **directoryinfo_실습** — `System.IO` 와 `DirectoryInfo`를 이용한 파일/폴더 조작. :contentReference[oaicite:12]{index=12}
- **FileExplore / FileExplore_image / 탐색기** — 파일 탐색기 UI, 이미지 미리보기 등 파일 시스템 탐색 기능 구현. :contentReference[oaicite:13]{index=13}

### Windows Forms(WinForms) 기본 컨트롤
- **기본_컨트롤** — 버튼/라벨/텍스트박스 등 기본 컨트롤 실습. :contentReference[oaicite:14]{index=14}
- **리스트_뷰(`list_view`)** — `ListView` 컨트롤 사용/컬럼/아이템/아이콘 표시. :contentReference[oaicite:15]{index=15}
- **트리_뷰(`tree_view`)** — `TreeView` 컨트롤로 계층 데이터 구성. :contentReference[oaicite:16]{index=16}
- **고급_컨트롤_리스트_뷰** — 리스트뷰 고급 기능(정렬/체크박스/그룹화 등) 실습. :contentReference[oaicite:17]{index=17}
- **계산기** — WinForms로 계산기 UI/이벤트 처리 구현. :contentReference[oaicite:18]{index=18}
- **WindowsFormsApp1** — 기본 WinForms 템플릿 기반 예제. :contentReference[oaicite:19]{index=19}

### .NET & 기타 프로젝트
- **NET/ myMLApp** — `.NET` 관련 상위 폴더 내 `myMLApp` 예제(프로파일/타겟 프레임워크 주의). :contentReference[oaicite:20]{index=20}
- **myMLApp** — 동일/유사명 프로젝트(콘솔 또는 WinForms일 가능성, 폴더별 `*.csproj`로 확인). :contentReference[oaicite:21]{index=21}
- **FileEx** — 파일 입출력/예외처리 실습(폴더명 축약으로 보임). :contentReference[oaicite:22]{index=22}
- **README.md** — 본 설명 문서. :contentReference[oaicite:23]{index=23}

> 🔎 각 폴더 안 구체 파일명(`Program.cs`, `Form1.cs`, `*.Designer.cs`, `*.csproj`)은 GitHub 폴더 페이지에서 확인 가능합니다. 현재 공개 페이지에서 상위 구조는 확인되지만, 일시적 로딩 오류로 하위 목록이 부분 표시될 수 있어요. :contentReference[oaicite:24]{index=24}

---

## ▶️ 실행 방법(Quick Start)

아래는 **콘솔/WinForms 프로젝트** 공통 실행 흐름입니다. (Windows 기준)

### 1) Visual Studio로 실행
1. **Visual Studio** 실행 → `파일 > 폴더 열기` 로 해당 폴더 선택  
2. 솔루션/프로젝트가 감지되면 **복원(Restore)**  
3. `시작(▶)` 버튼으로 실행 (WinForms는 폼 창이 뜹니다)

### 2) dotnet CLI로 실행(콘솔/일부 WinForms)
```bash
# 프로젝트 폴더로 이동 (csproj가 있는 위치)
cd path/to/ProjectFolder

# 패키지 복원 및 실행
dotnet restore
dotnet run
