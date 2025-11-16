using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace PrototypingManagers
{
	// Token: 0x0200004B RID: 75
	public static class GlobalDebugImpl : Object
	{
		// Token: 0x0600092D RID: 2349 RVA: 0x000BADC4 File Offset: 0x000B8FC4
		// Note: this type is marked as 'beforefieldinit'.
		static GlobalDebugImpl()
		{
			Il2CppClassPointerStore<GlobalDebugImpl>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "PrototypingManagers", "GlobalDebugImpl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalDebugImpl>.NativeClassPtr);
			GlobalDebugImpl.NativeMethodInfoPtr_RegisterMethod_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalDebugImpl>.NativeClassPtr, 100664766);
			GlobalDebugImpl.NativeMethodInfoPtr_OutputArchiveAndLog_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalDebugImpl>.NativeClassPtr, 100664767);
			GlobalDebugImpl.NativeMethodInfoPtr_OpenLogDirectory_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalDebugImpl>.NativeClassPtr, 100664768);
			GlobalDebugImpl.NativeMethodInfoPtr_GotoEmptyScene_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalDebugImpl>.NativeClassPtr, 100664769);
			GlobalDebugImpl.NativeMethodInfoPtr_GotoMainScene_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalDebugImpl>.NativeClassPtr, 100664770);
			GlobalDebugImpl.NativeMethodInfoPtr_ShowExplorer_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalDebugImpl>.NativeClassPtr, 100664771);
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x000BAE6C File Offset: 0x000B906C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37024, XrefRangeEnd = 37034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterMethod()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalDebugImpl.NativeMethodInfoPtr_RegisterMethod_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x000BAE94 File Offset: 0x000B9094
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 37068, RefRangeEnd = 37069, XrefRangeStart = 37034, XrefRangeEnd = 37068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OutputArchiveAndLog()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalDebugImpl.NativeMethodInfoPtr_OutputArchiveAndLog_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x000BAEBC File Offset: 0x000B90BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37069, XrefRangeEnd = 37083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OpenLogDirectory()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalDebugImpl.NativeMethodInfoPtr_OpenLogDirectory_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x000BAEE4 File Offset: 0x000B90E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37083, XrefRangeEnd = 37087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GotoEmptyScene()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalDebugImpl.NativeMethodInfoPtr_GotoEmptyScene_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x000BAF0C File Offset: 0x000B910C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37087, XrefRangeEnd = 37091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GotoMainScene()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalDebugImpl.NativeMethodInfoPtr_GotoMainScene_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x000BAF34 File Offset: 0x000B9134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37091, XrefRangeEnd = 37098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ShowExplorer(string path)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalDebugImpl.NativeMethodInfoPtr_ShowExplorer_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x00007504 File Offset: 0x00005704
		public GlobalDebugImpl(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040005E4 RID: 1508
		private static readonly IntPtr NativeMethodInfoPtr_RegisterMethod_Public_Static_Void_0;

		// Token: 0x040005E5 RID: 1509
		private static readonly IntPtr NativeMethodInfoPtr_OutputArchiveAndLog_Public_Static_Void_0;

		// Token: 0x040005E6 RID: 1510
		private static readonly IntPtr NativeMethodInfoPtr_OpenLogDirectory_Public_Static_Void_0;

		// Token: 0x040005E7 RID: 1511
		private static readonly IntPtr NativeMethodInfoPtr_GotoEmptyScene_Public_Static_Void_0;

		// Token: 0x040005E8 RID: 1512
		private static readonly IntPtr NativeMethodInfoPtr_GotoMainScene_Public_Static_Void_0;

		// Token: 0x040005E9 RID: 1513
		private static readonly IntPtr NativeMethodInfoPtr_ShowExplorer_Private_Static_Void_String_0;
	}
}
