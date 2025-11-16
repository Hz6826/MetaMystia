using System;
using DEYU.Singletons;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace PrototypingManagers
{
	// Token: 0x02000049 RID: 73
	public class EADebugConsole : MonoSingletonPersistant<EADebugConsole>
	{
		// Token: 0x060008E0 RID: 2272 RVA: 0x000BA07C File Offset: 0x000B827C
		// Note: this type is marked as 'beforefieldinit'.
		static EADebugConsole()
		{
			Il2CppClassPointerStore<EADebugConsole>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "PrototypingManagers", "EADebugConsole");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EADebugConsole>.NativeClassPtr);
			EADebugConsole.NativeFieldInfoPtr_bugHelperText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EADebugConsole>.NativeClassPtr, "bugHelperText");
			EADebugConsole.NativeFieldInfoPtr_exportText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EADebugConsole>.NativeClassPtr, "exportText");
			EADebugConsole.NativeFieldInfoPtr_hideConsoleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EADebugConsole>.NativeClassPtr, "hideConsoleText");
			EADebugConsole.NativeFieldInfoPtr_newGameMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EADebugConsole>.NativeClassPtr, "newGameMode");
			EADebugConsole.NativeFieldInfoPtr_openLogText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EADebugConsole>.NativeClassPtr, "openLogText");
			EADebugConsole.NativeFieldInfoPtr_shouldOnGUIBuffConsoleShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EADebugConsole>.NativeClassPtr, "shouldOnGUIBuffConsoleShown");
			EADebugConsole.NativeFieldInfoPtr_showConsoleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EADebugConsole>.NativeClassPtr, "showConsoleText");
			EADebugConsole.NativeFieldInfoPtr_skipText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EADebugConsole>.NativeClassPtr, "skipText");
			EADebugConsole.NativeFieldInfoPtr_welcomeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EADebugConsole>.NativeClassPtr, "welcomeText");
			EADebugConsole.NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EADebugConsole>.NativeClassPtr, 100664738);
			EADebugConsole.NativeMethodInfoPtr_OnAwake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EADebugConsole>.NativeClassPtr, 100664739);
			EADebugConsole.NativeMethodInfoPtr_RefreshText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EADebugConsole>.NativeClassPtr, 100664740);
			EADebugConsole.NativeMethodInfoPtr_ShowExplorer_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EADebugConsole>.NativeClassPtr, 100664741);
			EADebugConsole.NativeMethodInfoPtr_CopyFilesRecursively_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EADebugConsole>.NativeClassPtr, 100664742);
			EADebugConsole.NativeMethodInfoPtr_DeletDirectoriesRecursive_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EADebugConsole>.NativeClassPtr, 100664743);
			EADebugConsole.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EADebugConsole>.NativeClassPtr, 100664744);
			EADebugConsole.NativeMethodInfoPtr_Method_Internal_Static_Void_String_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EADebugConsole>.NativeClassPtr, 100664745);
			EADebugConsole.NativeMethodInfoPtr_Method_Internal_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EADebugConsole>.NativeClassPtr, 100664746);
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x000BA214 File Offset: 0x000B8414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36388, XrefRangeEnd = 36484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EADebugConsole.NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x000BA248 File Offset: 0x000B8448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36484, XrefRangeEnd = 36488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnAwake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EADebugConsole.NativeMethodInfoPtr_OnAwake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x000BA284 File Offset: 0x000B8484
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 36524, RefRangeEnd = 36525, XrefRangeStart = 36488, XrefRangeEnd = 36524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EADebugConsole.NativeMethodInfoPtr_RefreshText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x000BA2B8 File Offset: 0x000B84B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36525, XrefRangeEnd = 36532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowExplorer(string itemPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EADebugConsole.NativeMethodInfoPtr_ShowExplorer_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x000BA2FC File Offset: 0x000B84FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 36544, RefRangeEnd = 36546, XrefRangeStart = 36532, XrefRangeEnd = 36544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyFilesRecursively(string sourcePath, string targetPath)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(sourcePath);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EADebugConsole.NativeMethodInfoPtr_CopyFilesRecursively_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x000BA344 File Offset: 0x000B8544
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 36555, RefRangeEnd = 36557, XrefRangeStart = 36546, XrefRangeEnd = 36555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeletDirectoriesRecursive(string name)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EADebugConsole.NativeMethodInfoPtr_DeletDirectoriesRecursive_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x000BA37C File Offset: 0x000B857C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36557, XrefRangeEnd = 36560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EADebugConsole() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EADebugConsole>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EADebugConsole.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x000BA3B8 File Offset: 0x000B85B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36560, XrefRangeEnd = 36566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_String_PDM_0(string path)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EADebugConsole.NativeMethodInfoPtr_Method_Internal_Static_Void_String_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x000BA3F0 File Offset: 0x000B85F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 36571, RefRangeEnd = 36573, XrefRangeStart = 36566, XrefRangeEnd = 36571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_String_0(string path)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EADebugConsole.NativeMethodInfoPtr_Method_Internal_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x00007212 File Offset: 0x00005412
		public EADebugConsole(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x060008EB RID: 2283 RVA: 0x000BA428 File Offset: 0x000B8628
		// (set) Token: 0x060008EC RID: 2284 RVA: 0x0000721B File Offset: 0x0000541B
		public unsafe string bugHelperText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EADebugConsole.NativeFieldInfoPtr_bugHelperText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EADebugConsole.NativeFieldInfoPtr_bugHelperText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x060008ED RID: 2285 RVA: 0x000BA450 File Offset: 0x000B8650
		// (set) Token: 0x060008EE RID: 2286 RVA: 0x0000723A File Offset: 0x0000543A
		public unsafe string exportText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EADebugConsole.NativeFieldInfoPtr_exportText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EADebugConsole.NativeFieldInfoPtr_exportText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x060008EF RID: 2287 RVA: 0x000BA478 File Offset: 0x000B8678
		// (set) Token: 0x060008F0 RID: 2288 RVA: 0x00007259 File Offset: 0x00005459
		public unsafe string hideConsoleText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EADebugConsole.NativeFieldInfoPtr_hideConsoleText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EADebugConsole.NativeFieldInfoPtr_hideConsoleText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x060008F1 RID: 2289 RVA: 0x000BA4A0 File Offset: 0x000B86A0
		// (set) Token: 0x060008F2 RID: 2290 RVA: 0x00007278 File Offset: 0x00005478
		public unsafe bool newGameMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EADebugConsole.NativeFieldInfoPtr_newGameMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EADebugConsole.NativeFieldInfoPtr_newGameMode)) = value;
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x060008F3 RID: 2291 RVA: 0x000BA4C8 File Offset: 0x000B86C8
		// (set) Token: 0x060008F4 RID: 2292 RVA: 0x00007293 File Offset: 0x00005493
		public unsafe string openLogText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EADebugConsole.NativeFieldInfoPtr_openLogText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EADebugConsole.NativeFieldInfoPtr_openLogText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x060008F5 RID: 2293 RVA: 0x000BA4F0 File Offset: 0x000B86F0
		// (set) Token: 0x060008F6 RID: 2294 RVA: 0x000072B2 File Offset: 0x000054B2
		public unsafe bool shouldOnGUIBuffConsoleShown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EADebugConsole.NativeFieldInfoPtr_shouldOnGUIBuffConsoleShown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EADebugConsole.NativeFieldInfoPtr_shouldOnGUIBuffConsoleShown)) = value;
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x060008F7 RID: 2295 RVA: 0x000BA518 File Offset: 0x000B8718
		// (set) Token: 0x060008F8 RID: 2296 RVA: 0x000072CD File Offset: 0x000054CD
		public unsafe string showConsoleText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EADebugConsole.NativeFieldInfoPtr_showConsoleText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EADebugConsole.NativeFieldInfoPtr_showConsoleText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x060008F9 RID: 2297 RVA: 0x000BA540 File Offset: 0x000B8740
		// (set) Token: 0x060008FA RID: 2298 RVA: 0x000072EC File Offset: 0x000054EC
		public unsafe string skipText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EADebugConsole.NativeFieldInfoPtr_skipText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EADebugConsole.NativeFieldInfoPtr_skipText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x060008FB RID: 2299 RVA: 0x000BA568 File Offset: 0x000B8768
		// (set) Token: 0x060008FC RID: 2300 RVA: 0x0000730B File Offset: 0x0000550B
		public unsafe string welcomeText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EADebugConsole.NativeFieldInfoPtr_welcomeText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EADebugConsole.NativeFieldInfoPtr_welcomeText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040005B5 RID: 1461
		private static readonly IntPtr NativeFieldInfoPtr_bugHelperText;

		// Token: 0x040005B6 RID: 1462
		private static readonly IntPtr NativeFieldInfoPtr_exportText;

		// Token: 0x040005B7 RID: 1463
		private static readonly IntPtr NativeFieldInfoPtr_hideConsoleText;

		// Token: 0x040005B8 RID: 1464
		private static readonly IntPtr NativeFieldInfoPtr_newGameMode;

		// Token: 0x040005B9 RID: 1465
		private static readonly IntPtr NativeFieldInfoPtr_openLogText;

		// Token: 0x040005BA RID: 1466
		private static readonly IntPtr NativeFieldInfoPtr_shouldOnGUIBuffConsoleShown;

		// Token: 0x040005BB RID: 1467
		private static readonly IntPtr NativeFieldInfoPtr_showConsoleText;

		// Token: 0x040005BC RID: 1468
		private static readonly IntPtr NativeFieldInfoPtr_skipText;

		// Token: 0x040005BD RID: 1469
		private static readonly IntPtr NativeFieldInfoPtr_welcomeText;

		// Token: 0x040005BE RID: 1470
		private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;

		// Token: 0x040005BF RID: 1471
		private static readonly IntPtr NativeMethodInfoPtr_OnAwake_Protected_Virtual_Void_0;

		// Token: 0x040005C0 RID: 1472
		private static readonly IntPtr NativeMethodInfoPtr_RefreshText_Private_Void_0;

		// Token: 0x040005C1 RID: 1473
		private static readonly IntPtr NativeMethodInfoPtr_ShowExplorer_Private_Void_String_0;

		// Token: 0x040005C2 RID: 1474
		private static readonly IntPtr NativeMethodInfoPtr_CopyFilesRecursively_Public_Static_Void_String_String_0;

		// Token: 0x040005C3 RID: 1475
		private static readonly IntPtr NativeMethodInfoPtr_DeletDirectoriesRecursive_Public_Static_Void_String_0;

		// Token: 0x040005C4 RID: 1476
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040005C5 RID: 1477
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_String_PDM_0;

		// Token: 0x040005C6 RID: 1478
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_String_0;
	}
}
