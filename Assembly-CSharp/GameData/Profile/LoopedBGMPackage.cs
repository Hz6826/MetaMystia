using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002DD RID: 733
	public class LoopedBGMPackage : ScriptableObject
	{
		// Token: 0x060059B9 RID: 22969 RVA: 0x001CB838 File Offset: 0x001C9A38
		// Note: this type is marked as 'beforefieldinit'.
		static LoopedBGMPackage()
		{
			Il2CppClassPointerStore<LoopedBGMPackage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "LoopedBGMPackage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoopedBGMPackage>.NativeClassPtr);
			LoopedBGMPackage.NativeFieldInfoPtr_intro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopedBGMPackage>.NativeClassPtr, "intro");
			LoopedBGMPackage.NativeFieldInfoPtr_loop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopedBGMPackage>.NativeClassPtr, "loop");
			LoopedBGMPackage.NativeMethodInfoPtr_get_Valid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopedBGMPackage>.NativeClassPtr, 100681360);
			LoopedBGMPackage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopedBGMPackage>.NativeClassPtr, 100681361);
		}

		// Token: 0x17001EF0 RID: 7920
		// (get) Token: 0x060059BA RID: 22970 RVA: 0x001CB8B8 File Offset: 0x001C9AB8
		public unsafe bool Valid
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 219579, RefRangeEnd = 219581, XrefRangeStart = 219575, XrefRangeEnd = 219579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopedBGMPackage.NativeMethodInfoPtr_get_Valid_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060059BB RID: 22971 RVA: 0x001CB8F4 File Offset: 0x001C9AF4
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoopedBGMPackage() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoopedBGMPackage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopedBGMPackage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060059BC RID: 22972 RVA: 0x0003072E File Offset: 0x0002E92E
		public LoopedBGMPackage(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EEE RID: 7918
		// (get) Token: 0x060059BD RID: 22973 RVA: 0x001CB930 File Offset: 0x001C9B30
		// (set) Token: 0x060059BE RID: 22974 RVA: 0x00030737 File Offset: 0x0002E937
		public unsafe AudioClip intro
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMPackage.NativeFieldInfoPtr_intro);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMPackage.NativeFieldInfoPtr_intro), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EEF RID: 7919
		// (get) Token: 0x060059BF RID: 22975 RVA: 0x001CB960 File Offset: 0x001C9B60
		// (set) Token: 0x060059C0 RID: 22976 RVA: 0x00030756 File Offset: 0x0002E956
		public unsafe AudioClip loop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMPackage.NativeFieldInfoPtr_loop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMPackage.NativeFieldInfoPtr_loop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003BD9 RID: 15321
		private static readonly IntPtr NativeFieldInfoPtr_intro;

		// Token: 0x04003BDA RID: 15322
		private static readonly IntPtr NativeFieldInfoPtr_loop;

		// Token: 0x04003BDB RID: 15323
		private static readonly IntPtr NativeMethodInfoPtr_get_Valid_Public_get_Boolean_0;

		// Token: 0x04003BDC RID: 15324
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
