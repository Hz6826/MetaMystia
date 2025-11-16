using System;
using GameData.Core.MusicUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002D9 RID: 729
	public class IzakayaMusicProfile : ScriptableObject
	{
		// Token: 0x0600599D RID: 22941 RVA: 0x001CB418 File Offset: 0x001C9618
		// Note: this type is marked as 'beforefieldinit'.
		static IzakayaMusicProfile()
		{
			Il2CppClassPointerStore<IzakayaMusicProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "IzakayaMusicProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaMusicProfile>.NativeClassPtr);
			IzakayaMusicProfile.NativeFieldInfoPtr_switchEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaMusicProfile>.NativeClassPtr, "switchEntry");
			IzakayaMusicProfile.NativeFieldInfoPtr_passionP1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaMusicProfile>.NativeClassPtr, "passionP1");
			IzakayaMusicProfile.NativeFieldInfoPtr_passionP2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaMusicProfile>.NativeClassPtr, "passionP2");
			IzakayaMusicProfile.NativeFieldInfoPtr_passionP3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaMusicProfile>.NativeClassPtr, "passionP3");
			IzakayaMusicProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaMusicProfile>.NativeClassPtr, 100681352);
		}

		// Token: 0x0600599E RID: 22942 RVA: 0x001CB4AC File Offset: 0x001C96AC
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IzakayaMusicProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaMusicProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaMusicProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600599F RID: 22943 RVA: 0x000305E5 File Offset: 0x0002E7E5
		public IzakayaMusicProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EE6 RID: 7910
		// (get) Token: 0x060059A0 RID: 22944 RVA: 0x001CB4E8 File Offset: 0x001C96E8
		// (set) Token: 0x060059A1 RID: 22945 RVA: 0x000305EE File Offset: 0x0002E7EE
		public unsafe Il2CppStructArray<long> switchEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaMusicProfile.NativeFieldInfoPtr_switchEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<long>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaMusicProfile.NativeFieldInfoPtr_switchEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EE7 RID: 7911
		// (get) Token: 0x060059A2 RID: 22946 RVA: 0x001CB518 File Offset: 0x001C9718
		// (set) Token: 0x060059A3 RID: 22947 RVA: 0x0003060D File Offset: 0x0002E80D
		public IzakayaMusic.MusicChannelPackage passionP1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaMusicProfile.NativeFieldInfoPtr_passionP1);
				return new IzakayaMusic.MusicChannelPackage(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IzakayaMusic.MusicChannelPackage>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaMusicProfile.NativeFieldInfoPtr_passionP1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<IzakayaMusic.MusicChannelPackage>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001EE8 RID: 7912
		// (get) Token: 0x060059A4 RID: 22948 RVA: 0x001CB548 File Offset: 0x001C9748
		// (set) Token: 0x060059A5 RID: 22949 RVA: 0x0003063B File Offset: 0x0002E83B
		public IzakayaMusic.MusicChannelPackage passionP2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaMusicProfile.NativeFieldInfoPtr_passionP2);
				return new IzakayaMusic.MusicChannelPackage(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IzakayaMusic.MusicChannelPackage>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaMusicProfile.NativeFieldInfoPtr_passionP2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<IzakayaMusic.MusicChannelPackage>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001EE9 RID: 7913
		// (get) Token: 0x060059A6 RID: 22950 RVA: 0x001CB578 File Offset: 0x001C9778
		// (set) Token: 0x060059A7 RID: 22951 RVA: 0x00030669 File Offset: 0x0002E869
		public IzakayaMusic.MusicChannelPackage passionP3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaMusicProfile.NativeFieldInfoPtr_passionP3);
				return new IzakayaMusic.MusicChannelPackage(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IzakayaMusic.MusicChannelPackage>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaMusicProfile.NativeFieldInfoPtr_passionP3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<IzakayaMusic.MusicChannelPackage>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04003BCD RID: 15309
		private static readonly IntPtr NativeFieldInfoPtr_switchEntry;

		// Token: 0x04003BCE RID: 15310
		private static readonly IntPtr NativeFieldInfoPtr_passionP1;

		// Token: 0x04003BCF RID: 15311
		private static readonly IntPtr NativeFieldInfoPtr_passionP2;

		// Token: 0x04003BD0 RID: 15312
		private static readonly IntPtr NativeFieldInfoPtr_passionP3;

		// Token: 0x04003BD1 RID: 15313
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
