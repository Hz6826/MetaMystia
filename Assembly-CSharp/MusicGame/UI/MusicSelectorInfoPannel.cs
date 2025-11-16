using System;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.UniversalUISystem;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace MusicGame.UI
{
	// Token: 0x0200002A RID: 42
	public class MusicSelectorInfoPannel : UIPanelExtern
	{
		// Token: 0x06000403 RID: 1027 RVA: 0x000AB814 File Offset: 0x000A9A14
		// Note: this type is marked as 'beforefieldinit'.
		static MusicSelectorInfoPannel()
		{
			Il2CppClassPointerStore<MusicSelectorInfoPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "MusicGame.UI", "MusicSelectorInfoPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicSelectorInfoPannel>.NativeClassPtr);
			MusicSelectorInfoPannel.NativeFieldInfoPtr_m_UIElementCluster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorInfoPannel>.NativeClassPtr, "m_UIElementCluster");
			MusicSelectorInfoPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorInfoPannel>.NativeClassPtr, 100663867);
			MusicSelectorInfoPannel.NativeMethodInfoPtr_SetMusicLabel_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorInfoPannel>.NativeClassPtr, 100663868);
			MusicSelectorInfoPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorInfoPannel>.NativeClassPtr, 100663869);
			MusicSelectorInfoPannel.NativeMethodInfoPtr_OnExitExtern_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorInfoPannel>.NativeClassPtr, 100663870);
			MusicSelectorInfoPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorInfoPannel>.NativeClassPtr, 100663871);
			MusicSelectorInfoPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorInfoPannel>.NativeClassPtr, 100663872);
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x000AB8D0 File Offset: 0x000A9AD0
		public unsafe override bool MutePanelCloseAudio
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicSelectorInfoPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x000AB918 File Offset: 0x000A9B18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 22403, RefRangeEnd = 22404, XrefRangeStart = 22354, XrefRangeEnd = 22403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMusicLabel(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorInfoPannel.NativeMethodInfoPtr_SetMusicLabel_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x000AB95C File Offset: 0x000A9B5C
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicSelectorInfoPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x000AB998 File Offset: 0x000A9B98
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnExitExtern()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicSelectorInfoPannel.NativeMethodInfoPtr_OnExitExtern_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x000AB9D4 File Offset: 0x000A9BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22404, XrefRangeEnd = 22406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicSelectorInfoPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x000ABA10 File Offset: 0x000A9C10
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 19396, RefRangeEnd = 19400, XrefRangeStart = 19396, XrefRangeEnd = 19400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MusicSelectorInfoPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicSelectorInfoPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorInfoPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00004412 File Offset: 0x00002612
		public MusicSelectorInfoPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x0600040B RID: 1035 RVA: 0x000ABA4C File Offset: 0x000A9C4C
		// (set) Token: 0x0600040C RID: 1036 RVA: 0x0000441B File Offset: 0x0000261B
		public unsafe UIElementCluster m_UIElementCluster
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorInfoPannel.NativeFieldInfoPtr_m_UIElementCluster);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorInfoPannel.NativeFieldInfoPtr_m_UIElementCluster), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400028C RID: 652
		private static readonly IntPtr NativeFieldInfoPtr_m_UIElementCluster;

		// Token: 0x0400028D RID: 653
		private static readonly IntPtr NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0;

		// Token: 0x0400028E RID: 654
		private static readonly IntPtr NativeMethodInfoPtr_SetMusicLabel_Public_Void_String_0;

		// Token: 0x0400028F RID: 655
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04000290 RID: 656
		private static readonly IntPtr NativeMethodInfoPtr_OnExitExtern_Protected_Virtual_Void_0;

		// Token: 0x04000291 RID: 657
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
