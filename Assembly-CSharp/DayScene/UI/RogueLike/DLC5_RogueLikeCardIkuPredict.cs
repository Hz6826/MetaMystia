using System;
using GameData.Core.Collections;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Night.RogueLike;

namespace DayScene.UI.RogueLike
{
	// Token: 0x020000DE RID: 222
	public class DLC5_RogueLikeCardIkuPredict : RogueLikeCard
	{
		// Token: 0x06001A7E RID: 6782 RVA: 0x000F6768 File Offset: 0x000F4968
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeCardIkuPredict()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeCardIkuPredict>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeCardIkuPredict");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardIkuPredict>.NativeClassPtr);
			DLC5_RogueLikeCardIkuPredict.NativeFieldInfoPtr_datas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardIkuPredict>.NativeClassPtr, "datas");
			DLC5_RogueLikeCardIkuPredict.NativeFieldInfoPtr_checkNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardIkuPredict>.NativeClassPtr, "checkNum");
			DLC5_RogueLikeCardIkuPredict.NativeMethodInfoPtr_UseCard_Public_Virtual_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardIkuPredict>.NativeClassPtr, 100668015);
			DLC5_RogueLikeCardIkuPredict.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_Rarity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardIkuPredict>.NativeClassPtr, 100668016);
			DLC5_RogueLikeCardIkuPredict.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardIkuPredict>.NativeClassPtr, 100668017);
			DLC5_RogueLikeCardIkuPredict.NativeMethodInfoPtr___n__0_Private_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardIkuPredict>.NativeClassPtr, 100668018);
		}

		// Token: 0x06001A7F RID: 6783 RVA: 0x000F6810 File Offset: 0x000F4A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70648, XrefRangeEnd = 70655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator UseCard(BossData.BossDataContext dataContext, RogueLikeCardBase.Rarity rarity, RogueLikeManager rogueLikeManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dataContext));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rarity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardIkuPredict.NativeMethodInfoPtr_UseCard_Public_Virtual_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001A80 RID: 6784 RVA: 0x000F6890 File Offset: 0x000F4A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70655, XrefRangeEnd = 70667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OverrideDescription(string oldDescription, RogueLikeCardBase.Rarity rarity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oldDescription);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rarity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardIkuPredict.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_Rarity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x000F68F4 File Offset: 0x000F4AF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeCardIkuPredict() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardIkuPredict>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardIkuPredict.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x000F6930 File Offset: 0x000F4B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator __n__0(BossData.BossDataContext dataContext, RogueLikeCardBase.Rarity rarity, RogueLikeManager rogueLikeManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dataContext));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rarity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardIkuPredict.NativeMethodInfoPtr___n__0_Private_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x00010695 File Offset: 0x0000E895
		public DLC5_RogueLikeCardIkuPredict(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x06001A84 RID: 6788 RVA: 0x000F69A8 File Offset: 0x000F4BA8
		// (set) Token: 0x06001A85 RID: 6789 RVA: 0x0001069E File Offset: 0x0000E89E
		public unsafe Il2CppReferenceArray<RarityDataMappingForDuration> datas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardIkuPredict.NativeFieldInfoPtr_datas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RarityDataMappingForDuration>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardIkuPredict.NativeFieldInfoPtr_datas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x06001A86 RID: 6790 RVA: 0x000F69D8 File Offset: 0x000F4BD8
		// (set) Token: 0x06001A87 RID: 6791 RVA: 0x000106BD File Offset: 0x0000E8BD
		public unsafe int checkNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardIkuPredict.NativeFieldInfoPtr_checkNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardIkuPredict.NativeFieldInfoPtr_checkNum)) = value;
			}
		}

		// Token: 0x040011B1 RID: 4529
		private static readonly IntPtr NativeFieldInfoPtr_datas;

		// Token: 0x040011B2 RID: 4530
		private static readonly IntPtr NativeFieldInfoPtr_checkNum;

		// Token: 0x040011B3 RID: 4531
		private static readonly IntPtr NativeMethodInfoPtr_UseCard_Public_Virtual_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0;

		// Token: 0x040011B4 RID: 4532
		private static readonly IntPtr NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_Rarity_0;

		// Token: 0x040011B5 RID: 4533
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040011B6 RID: 4534
		private static readonly IntPtr NativeMethodInfoPtr___n__0_Private_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0;

		// Token: 0x0200069C RID: 1692
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardIkuPredict+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x0600975B RID: 38747 RVA: 0x00288B70 File Offset: 0x00286D70
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardIkuPredict.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardIkuPredict>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardIkuPredict.__c__DisplayClass2_0>.NativeClassPtr);
				DLC5_RogueLikeCardIkuPredict.__c__DisplayClass2_0.NativeFieldInfoPtr_num = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardIkuPredict.__c__DisplayClass2_0>.NativeClassPtr, "num");
				DLC5_RogueLikeCardIkuPredict.__c__DisplayClass2_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardIkuPredict.__c__DisplayClass2_0>.NativeClassPtr, "<>9__1");
				DLC5_RogueLikeCardIkuPredict.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardIkuPredict.__c__DisplayClass2_0>.NativeClassPtr, 100668019);
				DLC5_RogueLikeCardIkuPredict.__c__DisplayClass2_0.NativeMethodInfoPtr__UseCard_b__1_Internal_Boolean_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardIkuPredict.__c__DisplayClass2_0>.NativeClassPtr, 100668020);
			}

			// Token: 0x0600975C RID: 38748 RVA: 0x00288BEC File Offset: 0x00286DEC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardIkuPredict.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardIkuPredict.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600975D RID: 38749 RVA: 0x00288C28 File Offset: 0x00286E28
			[CallerCount(0)]
			public unsafe bool _UseCard_b__1(Recipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardIkuPredict.__c__DisplayClass2_0.NativeMethodInfoPtr__UseCard_b__1_Internal_Boolean_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600975E RID: 38750 RVA: 0x00051DAD File Offset: 0x0004FFAD
			public __c__DisplayClass2_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003245 RID: 12869
			// (get) Token: 0x0600975F RID: 38751 RVA: 0x00288C78 File Offset: 0x00286E78
			// (set) Token: 0x06009760 RID: 38752 RVA: 0x00051DB6 File Offset: 0x0004FFB6
			public unsafe int num
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardIkuPredict.__c__DisplayClass2_0.NativeFieldInfoPtr_num);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardIkuPredict.__c__DisplayClass2_0.NativeFieldInfoPtr_num)) = value;
				}
			}

			// Token: 0x17003246 RID: 12870
			// (get) Token: 0x06009761 RID: 38753 RVA: 0x00288CA0 File Offset: 0x00286EA0
			// (set) Token: 0x06009762 RID: 38754 RVA: 0x00051DD1 File Offset: 0x0004FFD1
			public unsafe Func<Recipe, bool> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardIkuPredict.__c__DisplayClass2_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Recipe, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardIkuPredict.__c__DisplayClass2_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006221 RID: 25121
			private static readonly IntPtr NativeFieldInfoPtr_num;

			// Token: 0x04006222 RID: 25122
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x04006223 RID: 25123
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006224 RID: 25124
			private static readonly IntPtr NativeMethodInfoPtr__UseCard_b__1_Internal_Boolean_Recipe_0;
		}

		// Token: 0x0200069D RID: 1693
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardIkuPredict+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06009763 RID: 38755 RVA: 0x00288CD0 File Offset: 0x00286ED0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardIkuPredict.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardIkuPredict>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardIkuPredict.__c>.NativeClassPtr);
				DLC5_RogueLikeCardIkuPredict.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardIkuPredict.__c>.NativeClassPtr, "<>9");
				DLC5_RogueLikeCardIkuPredict.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardIkuPredict.__c>.NativeClassPtr, "<>9__2_0");
				DLC5_RogueLikeCardIkuPredict.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardIkuPredict.__c>.NativeClassPtr, 100668022);
				DLC5_RogueLikeCardIkuPredict.__c.NativeMethodInfoPtr__UseCard_b__2_0_Internal_Int32_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardIkuPredict.__c>.NativeClassPtr, 100668023);
			}

			// Token: 0x06009764 RID: 38756 RVA: 0x00288D4C File Offset: 0x00286F4C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardIkuPredict.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardIkuPredict.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009765 RID: 38757 RVA: 0x00288D88 File Offset: 0x00286F88
			[CallerCount(0)]
			public unsafe int _UseCard_b__2_0(Recipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardIkuPredict.__c.NativeMethodInfoPtr__UseCard_b__2_0_Internal_Int32_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009766 RID: 38758 RVA: 0x00051DF0 File Offset: 0x0004FFF0
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003247 RID: 12871
			// (get) Token: 0x06009767 RID: 38759 RVA: 0x00288DD8 File Offset: 0x00286FD8
			// (set) Token: 0x06009768 RID: 38760 RVA: 0x00051DF9 File Offset: 0x0004FFF9
			public unsafe static DLC5_RogueLikeCardIkuPredict.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardIkuPredict.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardIkuPredict.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardIkuPredict.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003248 RID: 12872
			// (get) Token: 0x06009769 RID: 38761 RVA: 0x00288E00 File Offset: 0x00287000
			// (set) Token: 0x0600976A RID: 38762 RVA: 0x00051E0B File Offset: 0x0005000B
			public unsafe static Func<Recipe, int> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardIkuPredict.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Recipe, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardIkuPredict.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006225 RID: 25125
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006226 RID: 25126
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04006227 RID: 25127
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006228 RID: 25128
			private static readonly IntPtr NativeMethodInfoPtr__UseCard_b__2_0_Internal_Int32_Recipe_0;
		}

		// Token: 0x0200069E RID: 1694
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardIkuPredict+<UseCard>d__2")]
		public sealed class _UseCard_d__2 : Object
		{
			// Token: 0x0600976B RID: 38763 RVA: 0x00288E28 File Offset: 0x00287028
			// Note: this type is marked as 'beforefieldinit'.
			static _UseCard_d__2()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardIkuPredict._UseCard_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardIkuPredict>.NativeClassPtr, "<UseCard>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardIkuPredict._UseCard_d__2>.NativeClassPtr);
				DLC5_RogueLikeCardIkuPredict._UseCard_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardIkuPredict._UseCard_d__2>.NativeClassPtr, "<>1__state");
				DLC5_RogueLikeCardIkuPredict._UseCard_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardIkuPredict._UseCard_d__2>.NativeClassPtr, "<>2__current");
				DLC5_RogueLikeCardIkuPredict._UseCard_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardIkuPredict._UseCard_d__2>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeCardIkuPredict._UseCard_d__2.NativeFieldInfoPtr_dataContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardIkuPredict._UseCard_d__2>.NativeClassPtr, "dataContext");
				DLC5_RogueLikeCardIkuPredict._UseCard_d__2.NativeFieldInfoPtr_rarity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardIkuPredict._UseCard_d__2>.NativeClassPtr, "rarity");
				DLC5_RogueLikeCardIkuPredict._UseCard_d__2.NativeFieldInfoPtr_rogueLikeManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardIkuPredict._UseCard_d__2>.NativeClassPtr, "rogueLikeManager");
				DLC5_RogueLikeCardIkuPredict._UseCard_d__2.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardIkuPredict._UseCard_d__2>.NativeClassPtr, "<>8__1");
				DLC5_RogueLikeCardIkuPredict._UseCard_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardIkuPredict._UseCard_d__2>.NativeClassPtr, 100668024);
				DLC5_RogueLikeCardIkuPredict._UseCard_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardIkuPredict._UseCard_d__2>.NativeClassPtr, 100668025);
				DLC5_RogueLikeCardIkuPredict._UseCard_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardIkuPredict._UseCard_d__2>.NativeClassPtr, 100668026);
				DLC5_RogueLikeCardIkuPredict._UseCard_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardIkuPredict._UseCard_d__2>.NativeClassPtr, 100668027);
				DLC5_RogueLikeCardIkuPredict._UseCard_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardIkuPredict._UseCard_d__2>.NativeClassPtr, 100668028);
				DLC5_RogueLikeCardIkuPredict._UseCard_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardIkuPredict._UseCard_d__2>.NativeClassPtr, 100668029);
			}

			// Token: 0x0600976C RID: 38764 RVA: 0x00288F58 File Offset: 0x00287158
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _UseCard_d__2(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardIkuPredict._UseCard_d__2>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardIkuPredict._UseCard_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600976D RID: 38765 RVA: 0x00288FA0 File Offset: 0x002871A0
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardIkuPredict._UseCard_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600976E RID: 38766 RVA: 0x00288FD4 File Offset: 0x002871D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70589, XrefRangeEnd = 70642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardIkuPredict._UseCard_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003250 RID: 12880
			// (get) Token: 0x0600976F RID: 38767 RVA: 0x00289010 File Offset: 0x00287210
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardIkuPredict._UseCard_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06009770 RID: 38768 RVA: 0x00289050 File Offset: 0x00287250
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70642, XrefRangeEnd = 70648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardIkuPredict._UseCard_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003251 RID: 12881
			// (get) Token: 0x06009771 RID: 38769 RVA: 0x00289084 File Offset: 0x00287284
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardIkuPredict._UseCard_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06009772 RID: 38770 RVA: 0x00051E1D File Offset: 0x0005001D
			public _UseCard_d__2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003249 RID: 12873
			// (get) Token: 0x06009773 RID: 38771 RVA: 0x002890C4 File Offset: 0x002872C4
			// (set) Token: 0x06009774 RID: 38772 RVA: 0x00051E26 File Offset: 0x00050026
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardIkuPredict._UseCard_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardIkuPredict._UseCard_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700324A RID: 12874
			// (get) Token: 0x06009775 RID: 38773 RVA: 0x002890EC File Offset: 0x002872EC
			// (set) Token: 0x06009776 RID: 38774 RVA: 0x00051E41 File Offset: 0x00050041
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardIkuPredict._UseCard_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardIkuPredict._UseCard_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700324B RID: 12875
			// (get) Token: 0x06009777 RID: 38775 RVA: 0x0028911C File Offset: 0x0028731C
			// (set) Token: 0x06009778 RID: 38776 RVA: 0x00051E60 File Offset: 0x00050060
			public unsafe DLC5_RogueLikeCardIkuPredict __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardIkuPredict._UseCard_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardIkuPredict>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardIkuPredict._UseCard_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700324C RID: 12876
			// (get) Token: 0x06009779 RID: 38777 RVA: 0x0028914C File Offset: 0x0028734C
			// (set) Token: 0x0600977A RID: 38778 RVA: 0x00051E7F File Offset: 0x0005007F
			public BossData.BossDataContext dataContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardIkuPredict._UseCard_d__2.NativeFieldInfoPtr_dataContext);
					return new BossData.BossDataContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardIkuPredict._UseCard_d__2.NativeFieldInfoPtr_dataContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700324D RID: 12877
			// (get) Token: 0x0600977B RID: 38779 RVA: 0x0028917C File Offset: 0x0028737C
			// (set) Token: 0x0600977C RID: 38780 RVA: 0x00051EAD File Offset: 0x000500AD
			public unsafe RogueLikeCardBase.Rarity rarity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardIkuPredict._UseCard_d__2.NativeFieldInfoPtr_rarity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardIkuPredict._UseCard_d__2.NativeFieldInfoPtr_rarity)) = value;
				}
			}

			// Token: 0x1700324E RID: 12878
			// (get) Token: 0x0600977D RID: 38781 RVA: 0x002891A4 File Offset: 0x002873A4
			// (set) Token: 0x0600977E RID: 38782 RVA: 0x00051EC8 File Offset: 0x000500C8
			public unsafe RogueLikeManager rogueLikeManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardIkuPredict._UseCard_d__2.NativeFieldInfoPtr_rogueLikeManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardIkuPredict._UseCard_d__2.NativeFieldInfoPtr_rogueLikeManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700324F RID: 12879
			// (get) Token: 0x0600977F RID: 38783 RVA: 0x002891D4 File Offset: 0x002873D4
			// (set) Token: 0x06009780 RID: 38784 RVA: 0x00051EE7 File Offset: 0x000500E7
			public unsafe DLC5_RogueLikeCardIkuPredict.__c__DisplayClass2_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardIkuPredict._UseCard_d__2.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardIkuPredict.__c__DisplayClass2_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardIkuPredict._UseCard_d__2.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006229 RID: 25129
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400622A RID: 25130
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400622B RID: 25131
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400622C RID: 25132
			private static readonly IntPtr NativeFieldInfoPtr_dataContext;

			// Token: 0x0400622D RID: 25133
			private static readonly IntPtr NativeFieldInfoPtr_rarity;

			// Token: 0x0400622E RID: 25134
			private static readonly IntPtr NativeFieldInfoPtr_rogueLikeManager;

			// Token: 0x0400622F RID: 25135
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04006230 RID: 25136
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006231 RID: 25137
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006232 RID: 25138
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006233 RID: 25139
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006234 RID: 25140
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006235 RID: 25141
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
